using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Categories;
using Tuber.Persistence.Subcategories;
using Tuber.Domain.Models;

namespace Tuber.Persistence.CategorySubcategories;
public static class CategorySubcategorySeeding
{
    public static readonly Guid MotorFuelId = Guid.Parse("e79d158e-dd3c-4b13-86da-e0b8f9109ff7");
    public static readonly Guid MotorInsuranceId = Guid.Parse("c7f625d8-3b1c-4861-9589-f2e85e0596b3");
    public static readonly Guid MotorTaxId = Guid.Parse("80172b90-d0e3-41f1-bc00-985fc14f5926");
    public static readonly Guid HouseholdServicesGasId = Guid.Parse("002e1e54-7359-4b50-aa57-0efb62f0a42c");
    public static readonly Guid HouseholdServicesElectricityId = Guid.Parse("7f50d5aa-2959-4629-8eaa-e824b311549f");
    public static readonly Guid HouseholdServicesWaterId = Guid.Parse("7870b00b-d2d3-481b-9701-73f386262e8b");
    public static readonly Guid HouseholdServicesMobileId = Guid.Parse("a913b3e2-ab64-4a83-8e61-b41930638b9f");
    public static readonly Guid InterestEarnedId = Guid.Parse("daaf4e6f-00dd-40c0-837f-cb566deb743f");

    public static readonly Guid EntertainmentGamblingId = Guid.Parse("a99dcad5-5ea6-4d71-9f8c-a7f3db005a83");

    public static void Seed(EntityTypeBuilder<CategorySubcategory> builder)
    {
        builder.HasData(
            new CategorySubcategory
            {
                CategorySubcategoryId = MotorFuelId,
                CategoryId = CategorySeeding.MotorCategoryId,
                SubcategoryId = SubcategorySeeding.FuelSubcategoryId,
                IsCoreCategorySubcategory= true,
            });

        builder.HasData(
            new CategorySubcategory
            {
                CategorySubcategoryId = MotorInsuranceId,
                CategoryId = CategorySeeding.MotorCategoryId,
                SubcategoryId = SubcategorySeeding.InsuranceSubcategoryId,
                IsCoreCategorySubcategory = true,
            });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = MotorTaxId,
               CategoryId = CategorySeeding.MotorCategoryId,
               SubcategoryId = SubcategorySeeding.RoadTaxSubcategoryId,
               IsCoreCategorySubcategory = true,
           });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId =HouseholdServicesGasId,
               CategoryId = CategorySeeding.HouseholdServicesCategoryId,
               SubcategoryId = SubcategorySeeding.GasSubcategoryId,
               IsCoreCategorySubcategory = true,
           });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = HouseholdServicesElectricityId,
               CategoryId = CategorySeeding.HouseholdServicesCategoryId,
               SubcategoryId = SubcategorySeeding.ElectricitySubcategoryId,
               IsCoreCategorySubcategory = true,
           });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = HouseholdServicesWaterId,
               CategoryId = CategorySeeding.HouseholdServicesCategoryId,
               SubcategoryId = SubcategorySeeding.WaterSubcategoryId,
               IsCoreCategorySubcategory = true,
           });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = HouseholdServicesMobileId,
               CategoryId = CategorySeeding.HouseholdServicesCategoryId,
               SubcategoryId = SubcategorySeeding.MobileSubcategoryId,
               IsCoreCategorySubcategory = true,
           });

        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = InterestEarnedId,
               CategoryId = CategorySeeding.InterestEarnedCategoryId,
               SubcategoryId = null,
               IsCoreCategorySubcategory = true,
           });


        builder.HasData(
           new CategorySubcategory
           {
               CategorySubcategoryId = EntertainmentGamblingId,
               CategoryId = CategorySeeding.EntertainmentCategoryId,
               SubcategoryId = SubcategorySeeding.GamblingSubcategoryId,
           });
    }
}
