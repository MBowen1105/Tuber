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
                    entry.Entity.CreatedByUserId = _currentUserService.User().UserId;
                    entry.Entity.CreatedOnUtc = _dateTimeService.UtcNow();
                    entry.Entity.UpdatedByUserName = null;
                    entry.Entity.UpdatedOnUtc = null;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedByUserName = _currentUserService.User().FullName;
                    entry.Entity.UpdatedOnUtc = _dateTimeService.UtcNow();
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
