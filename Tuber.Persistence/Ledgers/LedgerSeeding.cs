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
            },
            new Ledger
            {
                LedgerId = Guid.Parse("0a7eea23-0537-408e-935a-36e89ea0db6c"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 19),
                RowNumber = 4,
                Description = "EVERYDAYREWARD NET",
                Reference = "",
                TransactionType = "CREDIT",
                MoneyIn = 1,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.OtherIncomeCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.LoyaltySubcategoryId,
                TransferBankAccountId = null,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("069215d0-7731-4751-90f3-4e4e98cf676c"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 20),
                RowNumber = 1,
                Description = "M Bowen",
                Reference = "PROFIT TAKING",
                TransactionType = "CREDIT",
                MoneyIn = 200,
                MoneyOut = null,
                Balance = 4.65,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.Lloyds25PARAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("147f2b53-72cb-4bbb-adbf-14e036c97814"),
                BankAccountId = BankAccounts.BankAccountSeeding.Lloyds25PARAccountId,
                DateUtc = new DateTime(2022, 4, 20),
                RowNumber = 1,
                Description = "M Bowen",
                Reference = "PROFIT TAKING",
                TransactionType = "CREDIT",
                MoneyIn = null,
                MoneyOut = 200,
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
                LedgerId = Guid.Parse("6dcb4fb2f3864950ac00112b7a2dda36"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 1,
                Description = "HONDA FINANCE EURO",
                Reference = "0704899-2219333577",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 176.57,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.HondaMotorAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("bf009ba6-7586-4ab9-9597-87502f284a3f"),
                BankAccountId = BankAccounts.BankAccountSeeding.HondaMotorAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 1,
                Description = "HONDA FINANCE EURO",
                Reference = "0704899-2219333577",
                TransactionType = "DD",
                MoneyIn = 176.57,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.HondaMotorAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("1c13a7f0-7256-4765-abca-2d7d636e16f5"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 2,
                Description = "LABOUR PARTY",
                Reference = "653577715906242518",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 4.67,
                Balance = -176.59,
                CategoryId = Categories.CategorySeeding.PoliticalDonationsCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = null,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("31880754-8033-41c7-8886-e152fb80043c"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 3,
                Description = "BUPA CENTRAL A/C",
                Reference = "9086677780",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 126.32,
                Balance = -302.91,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.BupaHealthAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("1ca9a32c-64e3-49cb-91ef-7956d3962deb"),
                BankAccountId = BankAccounts.BankAccountSeeding.BupaHealthAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 1,
                Description = "BUPA CENTRAL A/C",
                Reference = "9086677780",
                TransactionType = "DD",
                MoneyIn = 126.32,
                MoneyOut = null,
                Balance = 126.32,
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
                LedgerId = Guid.Parse("442b688c-8329-418c-8f84-b77a0b61dfa0"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 4,
                Description = "DEBIT INTEREST",
                Reference = "INTEREST",
                TransactionType = "",
                MoneyIn = null,
                MoneyOut = 2.89,
                Balance = -305.80,
                CategoryId = Categories.CategorySeeding.BankChargesCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = null,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("a4f38fb9-2893-4be0-bba2-a111f053c65f"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 5,
                Description = "CYRUS SOLUTIONS",
                Reference = "LOAN TO CYSOL",
                TransactionType = "BP/SO",
                MoneyIn = null,
                MoneyOut = 30.00,
                Balance = -335.80,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.AnnaBankCySolCheckAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("17e934ca-2006-4624-b82e-673755e4a0e2"),
                BankAccountId = BankAccounts.BankAccountSeeding.AnnaBankCySolCheckAccountId,
                DateUtc = new DateTime(2022, 4, 21),
                RowNumber = 1,
                Description = "CYRUS SOLUTIONS",
                Reference = "LOAN TO CYSOL",
                TransactionType = "BP/SO",
                MoneyIn = 30.00,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.DirectorsLoanCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("b8625f27-c65d-448d-ad9f-b60cc7dfd735"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 28),
                RowNumber = 1,
                Description = "SCOTTISH FRIENDLY",
                Reference = "PSD/OBC10256454",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 90.94,
                Balance = -76.74,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.ScottishFriendlyPHIAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("4f8a8b62-6d95-4854-8add-fc31e0a6a50f"),
                BankAccountId = BankAccounts.BankAccountSeeding.ScottishFriendlyPHIAccountId,
                DateUtc = new DateTime(2022, 4, 28),
                RowNumber = 1,
                Description = "SCOTTISH FRIENDLY",
                Reference = "PSD/OBC10256454",
                TransactionType = "DD",
                MoneyIn = 90.94,
                MoneyOut = null,
                Balance = 90.94,
                CategoryId = Categories.CategorySeeding.PersonalHealthInsuranceCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("6cd73668-eb60-4d7b-94be-d2247f8ea4cc"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 28),
                RowNumber = 2,
                Description = "CAMELOT LOTTERY",
                Reference = "A00143/3965",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 8.00,
                Balance = -84.74,
                CategoryId = Categories.CategorySeeding.EntertainmentCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.GamblingSubcategoryId,
                TransferBankAccountId = null,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("819bd791-b27c-403f-97b9-899d73ca2060"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 4, 28),
                RowNumber = 3,
                Description = "EE LIMITED",
                Reference = "Q08791420316823829",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 30.45,
                Balance = -115.19,
                CategoryId = Categories.CategorySeeding.TransferCategoryId,
                SubcategoryId = null,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.EETelecomAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Ledger
            {
                LedgerId = Guid.Parse("216effe9-7e8e-497f-8aa2-8e58c4f07e62"),
                BankAccountId = BankAccounts.BankAccountSeeding.EETelecomAccountId,
                DateUtc = new DateTime(2022, 4, 28),
                RowNumber = 1,
                Description = "EE LIMITED",
                Reference = "Q08791420316823829",
                TransactionType = "DD",
                MoneyIn = 30.45,
                MoneyOut = null,
                Balance = 0.00,
                CategoryId = Categories.CategorySeeding.HouseholdServicesCategoryId,
                SubcategoryId = Subcategories.SubcategorySeeding.MobileSubcategoryId,
                TransferBankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                TransactionOrigin = TransactionOrigin.Seeded,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
