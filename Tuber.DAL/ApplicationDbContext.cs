using Microsoft.EntityFrameworkCore;
using Tuber.DAL.Configuration;
using Tuber.Domain.Models;

namespace Tuber.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
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
