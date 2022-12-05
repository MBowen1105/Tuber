using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Imports;

public class ImportConfiguration : IEntityTypeConfiguration<Import>
{
    public void Configure(EntityTypeBuilder<Import> builder)
    {
        builder.ToTable("Imports")
            .HasOne(x => x.ImportedByUser);

        builder.Property(x => x.BankAccountId)
            .IsRequired();

        builder.Property(x => x.ImportRowNumber)
            .IsRequired();

        builder.Property(x => x.DateValue)
            .HasMaxLength(10);

        builder.Property(x => x.DescriptionOnStatementValue)
            .HasMaxLength(40);

        builder.Property(x => x.DescriptionValue)
            .HasMaxLength(40);

        builder.Property(x => x.ReferenceOnStatementValue)
            .HasMaxLength(40);

        builder.Property(x => x.TransactionTypeValue)
            .HasMaxLength(10);

        builder.Property(x => x.MoneyInValue)
            .HasMaxLength(10);

        builder.Property(x => x.MoneyOutValue)
            .HasMaxLength(10);

        builder.Property(x => x.BalanceOnStatementValue)
            .HasMaxLength(10);

        builder.Property(x => x.SortCodeValue)
            .HasMaxLength(10);

        builder.Property(x => x.AccountNumberValue)
            .HasMaxLength(10);

        builder.Property(x => x.ImportRowStatus)
            .IsRequired();

        builder.Property(x => x.ImportedByUserId)
            .IsRequired();

        builder.Property(x => x.ImportedUtc)
            .IsRequired();
    }
}
