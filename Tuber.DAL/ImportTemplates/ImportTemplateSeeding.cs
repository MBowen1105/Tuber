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
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new ImportTemplate
            {
                ImportTemplateId = Guid.Parse("f642096e-6573-4deb-96be-efba9016499c"),
                TemplateName = "Lloyds Bank Template",
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
