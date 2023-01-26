using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Banks;
public static class BankSeeding
{
    public static readonly Guid CoOpBankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6");
    public static readonly Guid LloydsBankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9");
    public static readonly Guid BarclaysBankId = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64");
    public static readonly Guid VirginBankId = Guid.Parse("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf");
    public static readonly Guid WBBSBankId = Guid.Parse("5a250fff-d109-429a-b59d-e7582c6272a0");
    public static readonly Guid TSBBankId = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff");
    public static readonly Guid PayPalId = Guid.Parse("64fba8d3-cef0-4a73-8f69-3fecfd186bb1");
    public static readonly Guid PensionId = Guid.Parse("ac5c2909-d1c7-448a-b59c-8509e19b313d");
    public static readonly Guid PrincipalityId = Guid.Parse("72dfefb5-6408-4e5d-baaa-1217a2c230a4");
    public static readonly Guid HondaId = Guid.Parse("71302810-87a8-484c-83e2-148211a5b82d");
    public static readonly Guid BupaId = Guid.Parse("bd472814-2f59-4212-95b5-f0bb81192aff");
    public static readonly Guid AnnaBankId = Guid.Parse("7115fa18-0319-4d9e-a45a-b7974f0381cf");
    public static readonly Guid ScottishFriendlyId = Guid.Parse("bfd54588-6c22-43c9-a207-ce52c645f324");
    public static readonly Guid EETelecomId = Guid.Parse("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc");
    public static readonly Guid WorcestershireCouncilId = Guid.Parse("c5cff082-2dc8-4359-9909-30849738703e");
    public static readonly Guid VirginMoneyId = Guid.Parse("444c4c70-139e-4014-b4a4-0ffd1bc89276");

    public static void Seed(EntityTypeBuilder<Bank> builder)
    {
        builder.HasData(
            new Bank
            {
                BankId = CoOpBankId,
                BankName = "Co-Op Bank",
                OrderBy = 10,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = LloydsBankId,
                BankName = "Lloyds Bank",
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = BarclaysBankId,
                BankName = "Barclays Bank",
                OrderBy = 30,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = VirginBankId,
                BankName = "Virgin",
                OrderBy = 40,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Bank
            {
                BankId = WBBSBankId,
                BankName = "West Bromwich Building Society",
                OrderBy = 50,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Bank
            {
                BankId = TSBBankId,
                BankName = "TSB",
                OrderBy = 60,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = true,
            },
            new Bank
            {
                BankId = PayPalId,
                BankName = "PayPal",
                OrderBy = 70,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = PensionId,
                BankName = "Scottish Widows",
                OrderBy = 80,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = PrincipalityId,
                BankName = "Principality Building Society",
                OrderBy = 90,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = HondaId,
                BankName = "Honda Finance",
                OrderBy = 100,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = BupaId,
                BankName = "BUPA",
                OrderBy = 110,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = AnnaBankId,
                BankName = "Anna Bank",
                OrderBy = 120,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = ScottishFriendlyId,
                BankName = "Scottish Friendly",
                OrderBy = 130,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = EETelecomId,
                BankName = "EE Telecom",
                OrderBy = 140,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = WorcestershireCouncilId,
                BankName = "Worcestershire Council",
                OrderBy = 150,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = VirginMoneyId,
                BankName = "Virgin Money",
                OrderBy = 160,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            });
    }
}
