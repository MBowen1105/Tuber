using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Users;
using Tuber.Domain.Models;

namespace Tuber.DAL.ImportTemplates;
public static class ImportTemplateSeeding
{
    public static void Seed(EntityTypeBuilder<ImportTemplate> builder)
    {
        builder.HasData(
            new ImportTemplate
            {
                ImportTemplateId = Guid.Parse("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                TemplateName = "Co-Op Bank Template",
                ImportFileName = "",
                HeaderRowCount = 1,
                DateColumnNumber = 1,
                DescriptionOnStatementColumnNumber = 2,
                TransactionTypeColumnNumber = 3,
                MoneyInColumnNumber = 4,
                MoneyOutColumnNumber = 5,
                BalanceOnStatementColumnNumber = 6,
                SortCodeColumnNumber = null,
                AccountNumberColumnNumber = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new ImportTemplate
            {
                ImportTemplateId = Guid.Parse("f642096e-6573-4deb-96be-efba9016499c"),
                TemplateName = "Lloyds Bank Template",
                ImportFileName = "",
                HeaderRowCount = 1,
                DateColumnNumber = 1,
                DescriptionOnStatementColumnNumber = 5,
                TransactionTypeColumnNumber = 2,
                MoneyInColumnNumber = 7,
                MoneyOutColumnNumber = 6,
                BalanceOnStatementColumnNumber = 8,
                SortCodeColumnNumber = 3,
                AccountNumberColumnNumber = 4,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
