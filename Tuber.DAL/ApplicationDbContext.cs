using Microsoft.EntityFrameworkCore;
using Tuber.DAL.Configuration;
using Tuber.Domain.Common;
using Tuber.Domain.Interfaces.Infrastructure.DateTimes;
using Tuber.Domain.Interfaces.Infrastructure.Users;
using Tuber.Domain.Models;

namespace Tuber.DAL;

public class ApplicationDbContext : DbContext
{
    private readonly IDateTimeService _dateTimeService;
    private readonly ICurrentUserService _currentUserService;

    public DbSet<Bank> Banks { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IDateTimeService dateTimeService,
        ICurrentUserService currentUserService)
        : base(options)
    {
        _dateTimeService = dateTimeService;
        _currentUserService = currentUserService;
    }

    public override int SaveChanges()
    {
        var changedRows = ChangeTracker.Entries<AuditableEntity>();

        foreach (var entry in changedRows)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedByUserId = _currentUserService.UserId();
                    entry.Entity.CreatedOn = _dateTimeService.UtcNow();
                    entry.Entity.UpdatedByUserId = null;
                    entry.Entity.UpdatedOn = null;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedByUserId = _currentUserService.UserId();
                    entry.Entity.UpdatedOn = _dateTimeService.UtcNow();
                    break;
            }
        }
        return base.SaveChanges();
    }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BankConfiguration());
        modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
