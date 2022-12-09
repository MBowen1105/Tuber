using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Users;
using Tuber.Domain.Models;

namespace Tuber.DAL.Categories;
public static class CategorySeeding
{
    public static readonly Guid MOTOR_CATEGORY_ID = Guid.Parse("97ea6440-ddb5-42ad-967f-5c9d34646b14");
    public static readonly Guid TRANSFER_CATEGORY_ID = Guid.Parse("27d48d80-b231-4c28-b1e5-af2100d24913");

    public static void Seed(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                CategoryId = TRANSFER_CATEGORY_ID,
                CategoryName = "Transfer",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = MOTOR_CATEGORY_ID,
                CategoryName = "Motor",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = Guid.Parse("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                CategoryName = "Mortage",
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = Guid.Parse("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                CategoryName = "Child Maintenance",
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
