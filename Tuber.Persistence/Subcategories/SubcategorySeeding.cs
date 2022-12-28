using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Application.Models;

namespace Tuber.Persistence.Subcategories;
public static class SubcategorySeeding
{
    public static readonly Guid FUEL_SUBCATEGORY = Guid.Parse("cac01b14-67a7-4372-8eb1-5e9a0e8a007c");
    public static readonly Guid INSURANCE_SUBCATEGORY = Guid.Parse("179d1384-e290-4bb7-a52d-038a3221d330");
    public static readonly Guid TAX_SUBCATEGORY = Guid.Parse("3077c60b-5d01-4982-b60e-d032cf75d926");

    public static void Seed(EntityTypeBuilder<Subcategory> builder)
    {
        builder.HasData(
            new Subcategory
            {
                SubcategoryId = FUEL_SUBCATEGORY,
                SubcategoryName = "Fuel",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = INSURANCE_SUBCATEGORY,
                SubcategoryName = "Insurance",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = TAX_SUBCATEGORY,
                SubcategoryName = "Tax",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
