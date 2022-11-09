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

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.IsArchived)
            .IsRequired()
            .HasDefaultValue(false);

        BankAccountSeeding.Seed(builder);
    }
}
