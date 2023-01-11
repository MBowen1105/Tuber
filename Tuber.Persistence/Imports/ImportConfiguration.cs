using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Imports;

public class ImportConfiguration : IEntityTypeConfiguration<Import>
{
    public void Configure(EntityTypeBuilder<Import> builder)
    {
        builder.ToTable("Imports");

        builder.HasOne(x => x.BankAccount);

        builder.HasOne(x => x.ImportedByUser);

        builder.HasOne(x => x.CategorySubcategory);

        builder.Property(x => x.BankAccountId)
            .IsRequired();

        builder.Property(x => x.ImportRowNumber)
            .IsRequired();

        builder.Property(x => x.DateValueISO8601)
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

        builder.Property(x => x.CategorySubcategoryId);

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
