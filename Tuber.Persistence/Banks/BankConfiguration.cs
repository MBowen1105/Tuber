using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Banks;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> modelBuilder)
    {
        modelBuilder.ToTable("Banks");

        modelBuilder.HasMany(x => x.BankAccounts);

        modelBuilder.HasOne(x => x.ImportTemplate);

        modelBuilder.HasOne(x => x.CreatedByUser);

        modelBuilder.HasOne(x => x.UpdatedByUser);

        modelBuilder.Property(x => x.BankName)
            .IsRequired()
            .HasMaxLength(40);

        modelBuilder.Property(x => x.OrderBy)
            .IsRequired();

        modelBuilder.Property(x => x.CreatedByUserId)
            .IsRequired();

        modelBuilder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        modelBuilder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        BankSeeding.Seed(modelBuilder);
    }
}
