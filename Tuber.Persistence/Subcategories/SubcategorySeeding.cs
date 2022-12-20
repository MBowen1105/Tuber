using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Subcategories;
public static class SubcategorySeeding
{
    public static readonly Guid FUEL_SUBCATEGORY = Guid.Parse("cac01b14-67a7-4372-8eb1-5e9a0e8a007c");
    
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
            }); ;
    }
}
