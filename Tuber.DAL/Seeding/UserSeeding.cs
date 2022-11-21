using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class UserSeeding
{
    public static readonly User ADMIN_USER = new()
    {
        UserId = Guid.Parse("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
        FullName = "Mark Bowen",
        IsCoreUser = true,
        IsActive = true,
    };

    public static void Seed(EntityTypeBuilder<User> builder)
    {
        builder.HasData(ADMIN_USER);
    }
}
