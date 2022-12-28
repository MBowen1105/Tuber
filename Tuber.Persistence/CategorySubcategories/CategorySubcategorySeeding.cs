using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Categories;
using Tuber.Persistence.Subcategories;
using Tuber.Application.Models;

namespace Tuber.Persistence.CategorySubcategories;
public static class CategorySubcategorySeeding
{
    public static void Seed(EntityTypeBuilder<CategorySubcategory> builder)
    {
        builder.HasData(
            new CategorySubcategory
            {
                CategorySubcategoryId = Guid.Parse("e79d158e-dd3c-4b13-86da-e0b8f9109ff7"),
                CategoryId = CategorySeeding.MOTOR_CATEGORY_ID,
                SubcategoryId = SubcategorySeeding.FUEL_SUBCATEGORY,
            }); ;
    }
}
