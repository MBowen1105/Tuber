using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Categories;
public static class CategorySeeding
{
    public static readonly Guid TransferCategoryId = Guid.Parse("27d48d80-b231-4c28-b1e5-af2100d24913");
    public static readonly Guid MotorCategoryId = Guid.Parse("97ea6440-ddb5-42ad-967f-5c9d34646b14");
    public static readonly Guid MortgageCategoryId = Guid.Parse("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9");
    public static readonly Guid EntertainmentCategoryId = Guid.Parse("ff39de05-0b97-4c98-b013-9cee276774cf");
    public static readonly Guid HouseholdServicesCategoryId = Guid.Parse("93678674-f2b0-48a3-91c3-050b506d258d");
    public static readonly Guid BankChargesCategoryId = Guid.Parse("ba134b1e-095b-4dc7-800d-94f27a1d9747");
    public static readonly Guid InvestmentIncomeCategoryId = Guid.Parse("90af6d97-3a28-47e9-b180-6cd406782c56");
    public static readonly Guid ChildMaintenanceCategoryId = Guid.Parse("3eefa969-31e0-46d3-9d81-d514035dd3de");
    
    public static void Seed(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                CategoryId = TransferCategoryId,
                CategoryName = "Transfer",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = MotorCategoryId,
                CategoryName = "Motor",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = MortgageCategoryId,
                CategoryName = "Mortage",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = EntertainmentCategoryId,
                CategoryName = "Entertainment",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = HouseholdServicesCategoryId,
                CategoryName = "Household Services",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = BankChargesCategoryId,
                CategoryName = "Bank Charges",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = InvestmentIncomeCategoryId,
                CategoryName = "Investment Income",
                IsCoreCategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Category
            {
                CategoryId = ChildMaintenanceCategoryId,
                CategoryName = "Child Maintenance",
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
