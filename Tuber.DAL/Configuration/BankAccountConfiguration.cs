using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Seeding;
using Tuber.Domain.Models;

namespace Tuber.DAL.Configuration;
public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        builder.ToTable("BankAccount");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.UKBankAccount)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOn)
            .IsRequired();

        builder.Property(x => x.UpdatedByUserId)
            .IsRequired();

        builder.Property(x => x.UpdatedOn)
            .IsRequired();

        builder.Property(x => x.IsArchived)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        BankAccountSeeding.Seed(builder);
    }
}
