﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.ImportTemplates;
public static class ImportTemplateSeeding
{
    public static readonly Guid CoOpImportTemplateId = Guid.Parse("44ec6e81-2ebf-4ec7-84b2-f74a87431962");
    public static readonly Guid LloydsImportTemplateId = Guid.Parse("f642096e-6573-4deb-96be-efba9016499c");

    public static void Seed(EntityTypeBuilder<ImportTemplate> builder)
    {
        builder.HasData(
            new ImportTemplate
            {
                ImportTemplateId = CoOpImportTemplateId,
                ImportTemplateName = "Co-Op Bank Template",
                ImportFileName = "",
                ExpectedColumnCount = 6,
                ExpectedHeaderRowCount = 1,
                DateTemplate = "yyyy-mm-dd",
                DateColumnNumber = 1,
                DescriptionOnStatementColumnNumber = 2,
                ReferenceOnStatementStartCharacter = 19,
                TransactionTypeColumnNumber = 3,
                MoneyInColumnNumber = 4,
                MoneyOutColumnNumber = 5,
                BalanceOnStatementColumnNumber = 6,
                SortCodeColumnNumber = 0,
                AccountNumberColumnNumber = 0,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new ImportTemplate
            {
                ImportTemplateId = LloydsImportTemplateId,
                ImportTemplateName = "Lloyds Bank Template",
                ImportFileName = "",
                ExpectedColumnCount=8,
                ExpectedHeaderRowCount = 1,
                DateTemplate = "dd-mmm-yyyy",
                DateColumnNumber = 1,
                DescriptionOnStatementColumnNumber = 5,
                ReferenceOnStatementStartCharacter = 0,
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
