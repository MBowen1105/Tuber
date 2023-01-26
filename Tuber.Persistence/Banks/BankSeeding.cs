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
                OrderBy = 50,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = true,
            },
            new Bank
            {
                BankId = PayPalId,
                BankName = "PayPal",
                OrderBy = 60,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = PensionId,
                BankName = "Scottish Widows",
                OrderBy = 70,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            },
            new Bank
            {
                BankId = PrincipalityId,
                BankName = "Principality Building Society",
                OrderBy = 80,
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
                OrderBy = 100,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = false,
            });
    }
}
