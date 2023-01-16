using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                DateUtc = new DateTime(2022, 5, 30),
                Description = "EE LIMITED",
                Reference = "Q08791420324918228",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 24.57,
                Balance = 1406.32,
                CategoryId = Categories.CategorySeeding.HouseholdServicesCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.MobileSubcategoryId,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("b581cb5c-8510-48de-b292-bd02641ec08d"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 5, 30),
                Description = "CAMELOT LOTTERY",
                Reference = "A00143/3965",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 8,
                Balance = 1430.89,
                CategoryId = Categories.CategorySeeding.EntertainmentCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.GamblingSubcategoryId,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 5, 23),
                Description = "DEBIT INTEREST",
                Reference = "INTEREST",
                TransactionType = "DD",
                MoneyIn = 0.17,
                MoneyOut = null,
                Balance = 2056.32,
                CategoryId = Categories.CategorySeeding.BankChargesCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.DebitInterestSubcategoryId,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
