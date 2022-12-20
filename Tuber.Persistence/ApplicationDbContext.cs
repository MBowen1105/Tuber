using Microsoft.EntityFrameworkCore;
using Tuber.Persistence.BankAccounts;
using Tuber.Persistence.Banks;
using Tuber.Persistence.Categories;
using Tuber.Persistence.CategorySubcategories;
using Tuber.Persistence.Imports;
using Tuber.Persistence.ImportTemplates;
using Tuber.Persistence.Subcategories;
using Tuber.Persistence.Users;
using Tuber.Domain.Common;
using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.Persistence;

public class ApplicationDbContext : DbContext
{
    private readonly IDateTimeService _dateTimeService;
    private readonly ICurrentUserService _currentUserService;

    public DbSet<Bank> Banks { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<ImportTemplate> ImportTemplates { get; set; }
    public DbSet<Import> Imports { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Subcategory> Subcategories { get; set; }
    public DbSet<CategorySubcategory> CategorySubcategories { get; set; }

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
        var currentUser = _currentUserService.User();

        //  Get all change trackers for entties that derive from the "AuditableEntity" class
        //  (The class that has the Created/Updated/ByDate fields.)
        var changedRows = ChangeTracker.Entries<AuditableEntity>();

        foreach (var entry in changedRows)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedByUserId = currentUser.UserId;
                    entry.Entity.CreatedOnUtc = _dateTimeService.UtcNow();
                    entry.Entity.UpdatedByUserId = null;
                    entry.Entity.UpdatedOnUtc = null;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedByUserId = _currentUserService.User().UserId;
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
        modelBuilder.ApplyConfiguration(new ImportTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new ImportConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new SubcategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CategorySubcategoryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
