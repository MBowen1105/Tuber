using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.BankAccounts;
public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        builder.ToTable("BankAccounts");

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.BankAccountName)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.UKSortCode)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(x => x.UKBankAccount)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.BankId)
           .IsRequired();

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        BankAccountSeeding.Seed(builder);
    }
}
