using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Subcategories;
public static class SubcategorySeeding
{
    public static readonly Guid FuelSubcategoryId = Guid.Parse("cac01b14-67a7-4372-8eb1-5e9a0e8a007c");
    public static readonly Guid RepaymentsSubcategoryId = Guid.Parse("5ab8de02-7a92-4df0-8ab3-8c3450fd9545");
    public static readonly Guid InsuranceSubcategoryId = Guid.Parse("179d1384-e290-4bb7-a52d-038a3221d330");
    public static readonly Guid RoadTaxSubcategoryId = Guid.Parse("3077c60b-5d01-4982-b60e-d032cf75d926");
    public static readonly Guid ElectricitySubcategoryId = Guid.Parse("66e06ca1-305c-48db-88bc-155b040fc82f");
    public static readonly Guid GasSubcategoryId = Guid.Parse("04ff391a-26fc-408b-b930-731114e2d994");
    public static readonly Guid WaterSubcategoryId = Guid.Parse("566195ce-d7a0-4252-8258-8b7b76b7846c");
    public static readonly Guid MobileSubcategoryId = Guid.Parse("d1d1f7ac-1609-4537-a965-eb118ce91a5b");
    public static readonly Guid DebitInterestSubcategoryId = Guid.Parse("ccbd867f-a971-4d3c-b879-2fccb8b92981");
    public static readonly Guid GamblingSubcategoryId = Guid.Parse("85ae154e-960e-4d35-8e77-a9e7d71eddf1");
    public static readonly Guid InternetSubcategoryId = Guid.Parse("de86efb2-764c-48b0-841a-7e29ecb83640");
    public static readonly Guid LoyaltySubcategoryId = Guid.Parse("45048692-c142-48e4-83b8-fdd7177443c9");
    public static readonly Guid CouncilTaxSubcategoryId = Guid.Parse("cb84a787-21d3-48eb-96c7-4dc404a8793d");

    public static void Seed(EntityTypeBuilder<Subcategory> builder)
    {
        builder.HasData(
            new Subcategory
            {
                SubcategoryId = FuelSubcategoryId,
                SubcategoryName = "Fuel",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = InsuranceSubcategoryId,
                SubcategoryName = "Insurance",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = RoadTaxSubcategoryId,
                SubcategoryName = "Road Tax",
                IsCoreSubcategory = true,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
           new Subcategory
           {
               SubcategoryId = ElectricitySubcategoryId,
               SubcategoryName = "Electricity",
               IsCoreSubcategory = true,
               CreatedOnUtc = DateTime.UtcNow,
               CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
           });

        builder.HasData(
           new Subcategory
           {
               SubcategoryId = GasSubcategoryId,
               SubcategoryName = "Gas",
               IsCoreSubcategory = true,
               CreatedOnUtc = DateTime.UtcNow,
               CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
           });

        builder.HasData(
           new Subcategory
           {
               SubcategoryId = WaterSubcategoryId,
               SubcategoryName = "Water",
               IsCoreSubcategory = true,
               CreatedOnUtc = DateTime.UtcNow,
               CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
           });

        builder.HasData(
          new Subcategory
          {
              SubcategoryId = MobileSubcategoryId,
              SubcategoryName = "Mobile",
              IsCoreSubcategory = true,
              CreatedOnUtc = DateTime.UtcNow,
              CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
          });

        builder.HasData(
          new Subcategory
          {
              SubcategoryId = DebitInterestSubcategoryId,
              SubcategoryName = "Debit Interest",
              IsCoreSubcategory = true,
              CreatedOnUtc = DateTime.UtcNow,
              CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
          });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = GamblingSubcategoryId,
                SubcategoryName = "Gambling",
                IsCoreSubcategory = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = InternetSubcategoryId,
                SubcategoryName = "Internet",
                IsCoreSubcategory = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
            new Subcategory
            {
                SubcategoryId = RepaymentsSubcategoryId,
                SubcategoryName = "Repayments",
                IsCoreSubcategory = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });

        builder.HasData(
           new Subcategory
           {
               SubcategoryId = LoyaltySubcategoryId,
               SubcategoryName = "Loyalty",
               IsCoreSubcategory = false,
               CreatedOnUtc = DateTime.UtcNow,
               CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
           });

        builder.HasData(
           new Subcategory
           {
               SubcategoryId = CouncilTaxSubcategoryId,
               SubcategoryName = "Council Tax",
               IsCoreSubcategory = false,
               CreatedOnUtc = DateTime.UtcNow,
               CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
           });
    }
}
