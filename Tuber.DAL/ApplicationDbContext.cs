using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Banks.Models;

namespace Tuber.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<BankModel> Banks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankModel>(entity =>
        {
            entity.ToTable("Bank");
            entity.HasKey(e => e.Id);
        });

        modelBuilder.SeedBanks();

        base.OnModelCreating(modelBuilder);
    }

}
