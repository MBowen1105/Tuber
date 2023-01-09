﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.BankAccounts;
public static class BankAccountSeeding
{
    public static readonly Guid CoOpSalaryAccountId = Guid.Parse("0c942b54-d561-499a-843b-e4387e7e6415");
    public static readonly Guid CoOpCashAccountId = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116");
    public static readonly Guid CoOpSavingsAccountId = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf");
    public static readonly Guid Lloyds93DIXAccountId = Guid.Parse("72fcf015-7f1b-49ef-8ea3-25d1ed15b936");
    public static readonly Guid Lloyds25PARAccountId = Guid.Parse("c38c85bd-19db-4b90-a1fa-aeb74610b70b");
    public static readonly Guid TSBBankAccountId = Guid.Parse("8cd1c1cf-a8e6-4148-a78c-99cd34c02997");

    public static void Seed(EntityTypeBuilder<BankAccount> builder)
    {
        builder.HasData(
            new BankAccount
            {
                BankAccountId = CoOpSalaryAccountId,
                BankId = Banks.BankSeeding.CoOpBankId,
                BankAccountName = "Salary",
                UKSortCode = "089191",
                UKBankAccount = "09411905",
                OrderBy = 10,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = CoOpCashAccountId,
                BankId = Banks.BankSeeding.CoOpBankId,
                BankAccountName = "Cash",
                UKSortCode = "089191",
                UKBankAccount = "00985630",
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = CoOpSavingsAccountId,
                BankId = Banks.BankSeeding.CoOpBankId,
                BankAccountName = "Savings",
                UKSortCode = "089191",
                UKBankAccount = "09405515",
                OrderBy = 30,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Lloyds93DIXAccountId,
                BankId = Banks.BankSeeding.LloydsBankId,
                BankAccountName = "Lloyds 93DIX",
                UKSortCode = "901111",
                UKBankAccount = "09405515",
                OrderBy = 10,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.LloydsImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Lloyds25PARAccountId,
                BankId = Banks.BankSeeding.LloydsBankId,
                BankAccountName = "Lloyds 25PAR",
                UKSortCode = "901111",
                UKBankAccount = "09405515",
                OrderBy = 20,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.LloydsImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = TSBBankAccountId,
                BankId = Banks.BankSeeding.TSBBankId,
                BankAccountName = "TSB Bank Account",
                UKSortCode = "440191",
                UKBankAccount = "98765555",
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = true,
            });
    }
}
