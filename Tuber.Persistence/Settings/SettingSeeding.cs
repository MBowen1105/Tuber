using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Settings;
public static class SettingSeeding
{
    public static void Seed(EntityTypeBuilder<Setting> builder)
    {
        builder.HasData(
            new Setting
            {
                CategorySuggestionHorizonDays = 365,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
