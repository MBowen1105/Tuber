using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Institutions;
public static class InstitutionSeeding
{
    public static readonly Guid CoOpBankInstitutionId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6");
    public static readonly Guid LloydsBankInstitutionId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9");
    public static readonly Guid BarclaysBankInstitutionId = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64");
    public static readonly Guid VirginMoneyInstitutionId = Guid.Parse("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf");
    public static readonly Guid WBBSInstitutionId = Guid.Parse("5a250fff-d109-429a-b59d-e7582c6272a0");
    public static readonly Guid TSBBankInstitutionId = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff");
    public static readonly Guid PayPalInstitutionId = Guid.Parse("64fba8d3-cef0-4a73-8f69-3fecfd186bb1");
    public static readonly Guid ScottishWidowsInstitutionId = Guid.Parse("ac5c2909-d1c7-448a-b59c-8509e19b313d");
    public static readonly Guid PrincipalityInstitutionId = Guid.Parse("72dfefb5-6408-4e5d-baaa-1217a2c230a4");
    public static readonly Guid HondaFinanceInstitutionId = Guid.Parse("71302810-87a8-484c-83e2-148211a5b82d");
    public static readonly Guid BupaInstitutionId = Guid.Parse("bd472814-2f59-4212-95b5-f0bb81192aff");
    public static readonly Guid AnnaBankInstitutionId = Guid.Parse("7115fa18-0319-4d9e-a45a-b7974f0381cf");
    public static readonly Guid ScottishFriendlyInstitutionId = Guid.Parse("bfd54588-6c22-43c9-a207-ce52c645f324");
    public static readonly Guid EETelecomInstitutionId = Guid.Parse("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc");
    public static readonly Guid WorcestershireCouncilInstitutionId = Guid.Parse("c5cff082-2dc8-4359-9909-30849738703e");

    public static void Seed(EntityTypeBuilder<Institution> builder)
    {
        builder.HasData(
            new Institution
            {
                InstitutionId = CoOpBankInstitutionId,
                InstitutionName = "Co-Op Bank",
                OrderBy = 10,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Institution
            {
                InstitutionId = LloydsBankInstitutionId,
                InstitutionName = "Lloyds Bank",
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Institution
            {
                InstitutionId = BarclaysBankInstitutionId,
                InstitutionName = "Barclays Bank",
                OrderBy = 30,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Institution
            {
                InstitutionId = VirginMoneyInstitutionId,
                InstitutionName = "Virgin Money",
                OrderBy = 40,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Institution
            {
                InstitutionId = WBBSInstitutionId,
                InstitutionName = "West Bromwich Building Society",
                OrderBy = 50,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Institution
            {
                InstitutionId = TSBBankInstitutionId,
                InstitutionName = "TSB Bank",
                OrderBy = 60,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = true,
            },
            new Institution
            {
                InstitutionId = PayPalInstitutionId,
                InstitutionName = "PayPal",
                OrderBy = 70,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = ScottishWidowsInstitutionId,
                InstitutionName = "Scottish Widows",
                OrderBy = 80,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = PrincipalityInstitutionId,
                InstitutionName = "Principality Building Society",
                OrderBy = 90,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = HondaFinanceInstitutionId,
                InstitutionName = "Honda Finance",
                OrderBy = 100,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = BupaInstitutionId,
                InstitutionName = "BUPA",
                OrderBy = 110,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = AnnaBankInstitutionId,
                InstitutionName = "Anna Bank",
                OrderBy = 120,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = ScottishFriendlyInstitutionId,
                InstitutionName = "Scottish Friendly",
                OrderBy = 130,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = EETelecomInstitutionId,
                InstitutionName = "EE Telecom",
                OrderBy = 140,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Institution
            {
                InstitutionId = WorcestershireCouncilInstitutionId,
                InstitutionName = "Worcestershire Council",
                OrderBy = 150,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            });
    }
}
