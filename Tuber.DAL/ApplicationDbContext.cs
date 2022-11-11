using Microsoft.EntityFrameworkCore;
using Tuber.DAL.Configuration;
using Tuber.Domain.Interfaces.Infrastructure;
using Tuber.Domain.Models;

namespace Tuber.DAL;

public class ApplicationDbContext : DbContext
{
    private readonly IDateTimeService _dateTime;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime)
        : base(options)
    {
        _dateTime = dateTime;
    }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedByUserId = Guid.NewGuid();
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedByUserId = Guid.NewGuid();
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
