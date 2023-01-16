using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.AppConfigs;
public static class AppConfigSeeding
{
    public static void Seed(EntityTypeBuilder<AppConfig> builder)
    {
        builder.HasData(
            new AppConfig
            {
                AppConfigId = Guid.Parse("DE570E94-96CE-4FB8-B33E-22420790F577"),
                CategorySuggestionHorizonDays = 365,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
