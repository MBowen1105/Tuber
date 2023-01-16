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
                CategorySuggestionHorizonDays = 365,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
