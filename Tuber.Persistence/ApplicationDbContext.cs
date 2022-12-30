﻿using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces.Authentication;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Application.Models;
using Tuber.Persistence.BankAccounts;
using Tuber.Persistence.Banks;
using Tuber.Persistence.Categories;
using Tuber.Persistence.CategorySubcategories;
using Tuber.Persistence.Imports;
using Tuber.Persistence.ImportTemplates;
using Tuber.Persistence.Subcategories;
using Tuber.Persistence.Users;

namespace Tuber.Persistence;

public class ApplicationDbContext : DbContext
{
    private readonly ISystemClock _systemClock;
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
        ISystemClock systemClock,
        ICurrentUserService currentUserService)
        : base(options)
    {
        _systemClock = systemClock;
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
                    entry.Entity.CreatedOnUtc = _systemClock.UtcNow();
                    entry.Entity.UpdatedByUserId = null;
                    entry.Entity.UpdatedOnUtc = null;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedByUserId = _currentUserService.User().UserId;
                    entry.Entity.UpdatedOnUtc = _systemClock.UtcNow();
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