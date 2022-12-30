using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Categories;
using Tuber.Persistence.Subcategories;
using Tuber.Domain.Models;

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
                IsCoreCategorySubcategory= true,
            });

        builder.HasData(
            new CategorySubcategory
            {
                CategorySubcategoryId = Guid.Parse("c7f625d8-3b1c-4861-9589-f2e85e0596b3"),
                CategoryId = CategorySeeding.MOTOR_CATEGORY_ID,
                SubcategoryId = SubcategorySeeding.INSURANCE_SUBCATEGORY,
                IsCoreCategorySubcategory = true,
            });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = Guid.Parse("80172b90-d0e3-41f1-bc00-985fc14f5926"),
               CategoryId = CategorySeeding.MOTOR_CATEGORY_ID,
               SubcategoryId = SubcategorySeeding.TAX_SUBCATEGORY,
               IsCoreCategorySubcategory = true,
           });
    }
}
