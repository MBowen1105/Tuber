using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Banks;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        builder.ToTable("Banks")
            .HasMany(x => x.BankAccounts)
            .WithOne(x => x.Bank)
            .HasForeignKey(x=>x.BankId);

        builder.HasOne(x => x.ImportTemplate);

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.BankName)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        BankSeeding.Seed(builder);
    }
}
