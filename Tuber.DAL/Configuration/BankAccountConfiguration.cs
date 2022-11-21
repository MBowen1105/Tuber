using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Seeding;
using Tuber.Domain.Models;

namespace Tuber.DAL.Configuration;
public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        builder.ToTable("BankAccounts")
            .HasOne(x => x.Bank);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.UKBankAccount)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.BankId)
           .IsRequired();

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserName)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(x => x.CreatedByUserName)
            .IsRequired();

        BankAccountSeeding.Seed(builder);
    }
}
