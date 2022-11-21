using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Seeding;
using Tuber.Domain.Models;

namespace Tuber.DAL.Configuration;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        builder.ToTable("Banks")
            .HasMany(x => x.BankAccounts)
            .WithOne(x => x.Bank);

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsActive)
                    .IsRequired()
                    .HasDefaultValue(true);

        BankSeeding.Seed(builder);
    }
}
