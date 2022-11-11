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
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedByUserId = _currentUserService.UserId();
                    entry.Entity.CreatedOn = _dateTimeService.UtcNow();
                    entry.Entity.UpdatedByUserId = _currentUserService.UserId();
                    entry.Entity.UpdatedOn = _dateTimeService.UtcNow();
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedByUserId = _currentUserService.UserId();
                    entry.Entity.UpdatedOn = _dateTimeService.UtcNow();
                    break;
            }
        }
        return base.SaveChanges();
    }

    public DbSet<Bank> Banks { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BankConfiguration());
        modelBuilder.ApplyConfiguration(new BankAccountConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
