﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                RowNumber = 1,
                Description = "PAYPAL PAYMENT",
                Reference = "576J2223CC7UY",
                TransactionType = "DD",
                MoneyIn = 11.89,
                MoneyOut = null,
                Balance = 11.89,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                IsDeleted = false,
                TransactionOrigin = TransactionOrigin.Seeded,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
             {
                 LedgerId = Guid.Parse("857fd6c8-e83f-4155-8909-64de3f18f566"),
                 BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
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
                LedgerId = Guid.Parse("d37a4933-756f-4e8a-9c93-d812472178f6"),
                BankAccountId = BankAccounts.BankAccountSeeding.PayPalAccountId,
                DateUtc = new DateTime(2022, 4, 6),
                RowNumber = 2,
                Description = "PAYPAL PAYMENT",
                Reference = "576J2223CC7UY",
                TransactionType = "DD",
                MoneyIn = 11.90,
                MoneyOut = null,
                Balance = 11.89 + 11.90,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
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
            },
            new Ledger
            {
                LedgerId = Guid.Parse("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 11),
                RowNumber = 2,
                Description = "TFR 93000810462300",
                Reference = "",
                TransactionType = "TRANSFER",
                MoneyIn = null,
                MoneyOut = 100.00,
                Balance = 464.63,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpCashAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpCashAccountId,
                DateUtc = new DateTime(2022, 4, 11),
                RowNumber = 3,
                Description = "TFR 93000810462300",
                Reference = "",
                TransactionType = "TRANSFER",
                MoneyIn = 100.00,
                MoneyOut = null,
                Balance = 464.63,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 14),
                RowNumber = 1,
                Description = "SCOTTISH WIDOWS",
                Reference = "PR859326H",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 450.00,
                Balance = 14.63,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.PensionAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("6495197d-b80d-4358-9c2c-4e52779614f0"),
                BankAccountId = BankAccounts.BankAccountSeeding.PensionAccountId,
                DateUtc = new DateTime(2022, 4, 14),
                RowNumber = 1,
                Description = "SCOTTISH WIDOWS",
                Reference = "PR859326H",
                TransactionType = "DD",
                MoneyIn = 450.00,
                MoneyOut = null,
                Balance = 450.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("06226032-0cd7-406c-ae33-90aa2061e045"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 1,
                Description = "PRINCIPALITY BS",
                Reference = "079271710",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 124.31,
                Balance = -109.68,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.PrincipalityMortgageAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                BankAccountId = BankAccounts.BankAccountSeeding.PrincipalityMortgageAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 1,
                Description = "PRINCIPALITY BS",
                Reference = "079271710",
                TransactionType = "DD",
                MoneyIn = 124.31,
                MoneyOut = null,
                Balance = 124.31,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 2,
                Description = "WEST BROMWICH BSOC",
                Reference = "9015660300023849",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 80.68,
                Balance = -190.36,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.WBBSSavingsAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                BankAccountId = BankAccounts.BankAccountSeeding.WBBSSavingsAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 1,
                Description = "WEST BROMWICH BSOC",
                Reference = "079271710",
                TransactionType = "DD",
                MoneyIn = 80.68,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("9980d6a7-949c-4375-83c9-186efe3c96e8"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 3,
                Description = "THE CO-OP BANK",
                Reference = "4552061305790731",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 5.99,
                Balance = -190.36,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpTravelCreditCardAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("6cc18b28-9390-4837-a181-0444810515e7"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpTravelCreditCardAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 1,
                Description = "THE CO-OP BANK",
                Reference = "4552061305790731",
                TransactionType = "DD",
                MoneyIn = 5.99,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
