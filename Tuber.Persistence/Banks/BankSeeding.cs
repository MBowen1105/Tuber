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
            });
    }
}
