using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Enums;
using Tuber.Domain.Models;
using Tuber.Persistence.Users;

namespace Tuber.Persistence.Ledgers;
public static class LedgerSeeding
{
    public static void Seed(EntityTypeBuilder<Ledger> builder)
    {
        builder.HasData(
            new Ledger
            {
                LedgerId = Guid.Parse("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 6),
                RowNumber = 1,
                Description = "PAYPAL PAYMENT",
                Reference = "576J2223CC7UY",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 11.89,
                Balance = 606.90,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.PayPalAccountId,
                IsDeleted = false,
                TransactionOrigin = TransactionOrigin.Seeded,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("b581cb5c-8510-48de-b292-bd02641ec08d"),
                BankAccountId = BankAccounts.BankAccountSeeding.PayPalAccountId,
                DateUtc = new DateTime(2022, 4, 6),
                RowNumber = 2,
                Description = "PAYPAL PAYMENT",
                Reference = "576J2223CC7UY",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 11.90,
                Balance = 595.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.PayPalAccountId,
                IsDeleted = false,
                TransactionOrigin = TransactionOrigin.Seeded,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 11),
                RowNumber = 1,
                Description = "PNET3584204-1",
                Reference = "",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 30.37,
                Balance = 564.63,
                CategoryId = Categories.CategorySeeding.HouseholdServicesCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.InternetSubcategoryId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
