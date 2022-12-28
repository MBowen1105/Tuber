
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Application.Models;

namespace Tuber.Persistence.ImportTemplates;

public class ImportTemplateConfiguration : IEntityTypeConfiguration<ImportTemplate>
{
    public void Configure(EntityTypeBuilder<ImportTemplate> builder)
    {
        builder.ToTable("ImportTemplates");

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.ImportTemplateName)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.ExpectedHeaderRowCount)
            .IsRequired();

        builder.Property(x => x.ExpectedColumnCount)
            .IsRequired();

        builder.Property(x => x.SeperatorChar)
            .HasMaxLength(1)
            .IsRequired();

        builder.Property(x => x.DateTemplate)
           .IsRequired()
           .HasMaxLength(20);

        builder.Property(x => x.DateColumnNumber)
            .IsRequired();

        builder.Property(x => x.DescriptionOnStatementColumnNumber)
            .IsRequired();

        builder.Property(x => x.ReferenceOnStatementStartCharacter)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(x => x.TransactionTypeColumnNumber)
           .IsRequired();

        builder.Property(x => x.MoneyInColumnNumber)
           .IsRequired();

        builder.Property(x => x.MoneyOutColumnNumber)
           .IsRequired();

        builder.Property(x => x.BalanceOnStatementColumnNumber)
           .IsRequired();

        builder.Property(x => x.SortCodeColumnNumber)
           .IsRequired();

        builder.Property(x => x.AccountNumberColumnNumber)
           .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        ImportTemplateSeeding.Seed(builder);
    }
}
