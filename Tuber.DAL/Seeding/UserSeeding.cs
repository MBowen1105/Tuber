using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class UserSeeding
{
    public static readonly Guid ADMIN_USER_ID = Guid.Parse("02ceedc1-d3b4-4e5e-8844-0d853c24463b");

    public static void Seed(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            {
                Id = ADMIN_USER_ID,
                FullName = "Mark Bowen",
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = ADMIN_USER_ID,
                IsArchived = false,
            });
    }
}
