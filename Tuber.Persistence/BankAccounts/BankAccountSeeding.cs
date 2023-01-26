using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.BankAccounts;
public static class BankAccountSeeding
{
    public static readonly Guid CoOpSalaryAccountId = Guid.Parse("0c942b54-d561-499a-843b-e4387e7e6415");
    public static readonly Guid CoOpCashAccountId = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116");
    public static readonly Guid CoOpSavingsAccountId = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf");
    public static readonly Guid CoOpTravelCreditCardAccountId = Guid.Parse("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e");

    public static readonly Guid Lloyds93DIXAccountId = Guid.Parse("72fcf015-7f1b-49ef-8ea3-25d1ed15b936");
    public static readonly Guid Lloyds25PARAccountId = Guid.Parse("c38c85bd-19db-4b90-a1fa-aeb74610b70b");
    
    public static readonly Guid BarclaysCheckAccountId = Guid.Parse("7326c494-50b1-4128-bb2c-f36a475f5b81");
    public static readonly Guid BarclaysAlexSavingsAccountId = Guid.Parse("7e42a92d-4296-4eb9-9d4c-db86051c42c7");
    public static readonly Guid BarclaysEthanSavingsAccountId = Guid.Parse("0dce26bf-cd3f-4bbf-b2f9-a47e95d7fb3b");
    
    public static readonly Guid TSBBankAccountId = Guid.Parse("8cd1c1cf-a8e6-4148-a78c-99cd34c02997");
    
    public static readonly Guid PayPalAccountId = Guid.Parse("c8637e26759849ce89d682f2f184f540");
    
    public static readonly Guid PensionAccountId = Guid.Parse("f0781ba0-c93d-4115-8230-7329e4708c07");
    
    public static readonly Guid PrincipalityMortgageAccountId = Guid.Parse("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a");
    
    public static readonly Guid WBBSSavingsAccountId = Guid.Parse("1b0a51db-1635-4df2-9faa-7f5d6f0450f1");
   
    public static readonly Guid HondaFinanceAccountId = Guid.Parse("85a437ee-b0b4-449c-9c81-8a2b40c94feb");
    
    public static readonly Guid BupaHealthAccountId = Guid.Parse("8219473f-a6c6-44ea-b9eb-561032dd372e");
    
    public static readonly Guid AnnaBankCySolCheckAccountId = Guid.Parse("6219e157-8c03-4eaa-b78f-4fde4a2b19d0");
    
    public static readonly Guid ScottishFriendlyPHIAccountId = Guid.Parse("7d516d57-1e24-4f0c-9e23-67200adabe51");
    
    public static readonly Guid EETelecomAccountId = Guid.Parse("315e3cc7-3dcd-4f16-906a-4f433df80139");
    
    public static readonly Guid CouncilTaxAccountId = Guid.Parse("bbce5ac1-da50-4ec7-8a72-3011174c649c");
    
    public static readonly Guid VirginISAAccountId = Guid.Parse("b1436024-ad18-4f15-8d24-2aba82ea12fa");


    public static void Seed(EntityTypeBuilder<BankAccount> builder)
    {
        builder.HasData(
            //Co-Op
            new BankAccount
            {
                BankAccountId = CoOpSalaryAccountId,
                BankId = Banks.BankSeeding.CoOpBankId,
                BankAccountName = "Salary",
                UKSortCode = "089191",
                UKBankAccount = "09411905",
                OpeningBalance = 595.01,
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
                OpeningBalance = 0,
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
                OpeningBalance = 0,
                OrderBy = 30,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            // Lloyds
            new BankAccount
            {
                BankAccountId = Lloyds93DIXAccountId,
                BankId = Banks.BankSeeding.LloydsBankId,
                BankAccountName = "Lloyds 93DIX",
                UKSortCode = "901111",
                UKBankAccount = "09405515",
                OpeningBalance = 0,
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
                OpeningBalance = 0,
                OrderBy = 20,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.LloydsImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            //  Barclays
            new BankAccount
            {
                BankAccountId = BarclaysCheckAccountId,
                BankId = Banks.BankSeeding.BarclaysBankId,
                BankAccountName = "Barclays Check A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = BarclaysAlexSavingsAccountId,
                BankId = Banks.BankSeeding.BarclaysBankId,
                BankAccountName = "Alexs Savings A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 20,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = BarclaysEthanSavingsAccountId,
                BankId = Banks.BankSeeding.BarclaysBankId,
                BankAccountName = "Ethans Savings A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 30,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            //  TSB
            new BankAccount
            {
                BankAccountId = TSBBankAccountId,
                BankId = Banks.BankSeeding.TSBBankId,
                BankAccountName = "TSB Bank Account",
                UKSortCode = "440191",
                UKBankAccount = "98765555",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Paypal
            new BankAccount
            {
                BankAccountId = PayPalAccountId,
                BankId = Banks.BankSeeding.PayPalId,
                BankAccountName = "PayPal",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Pension
            new BankAccount
            {
                BankAccountId = PensionAccountId,
                BankId = Banks.BankSeeding.PensionId,
                BankAccountName = "Scottish Widows Pension",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Principality
            new BankAccount
            {
                BankAccountId = PrincipalityMortgageAccountId,
                BankId = Banks.BankSeeding.PrincipalityId,
                BankAccountName = "Principality Building Society",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  WBBS
            new BankAccount
            {
                BankAccountId = WBBSSavingsAccountId,
                BankId = Banks.BankSeeding.WBBSBankId,
                BankAccountName = "West Bromwich Building Society",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Co-Op Travel Card
            new BankAccount
            {
                BankAccountId = CoOpTravelCreditCardAccountId,
                BankId = Banks.BankSeeding.CoOpBankId,
                BankAccountName = "Co-Op Travel Credit Card",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 40,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Honda Finance A/C
            new BankAccount
            {
                BankAccountId = HondaFinanceAccountId,
                BankId = Banks.BankSeeding.HondaId,
                BankAccountName = "Honda Finance",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  BUPA
            new BankAccount
            {
                BankAccountId = BupaHealthAccountId,
                BankId = Banks.BankSeeding.BupaId,
                BankAccountName = "BUPA Health A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Cyrus Solutions
            new BankAccount
            {
                BankAccountId = AnnaBankCySolCheckAccountId,
                BankId = Banks.BankSeeding.AnnaBankId,
                BankAccountName = "Cyrus Solutions Check A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Scottish Friendly
            new BankAccount
            {
                BankAccountId = ScottishFriendlyPHIAccountId,
                BankId = Banks.BankSeeding.ScottishFriendlyId,
                BankAccountName = "Scottish Friendly PHI A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  EE
            new BankAccount
            {
                BankAccountId = EETelecomAccountId,
                BankId = Banks.BankSeeding.EETelecomId,
                BankAccountName = "EE Telecom A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Worcs Council Tax A/C
            new BankAccount
            {
                BankAccountId = CouncilTaxAccountId,
                BankId = Banks.BankSeeding.WorcestershireCouncilId,
                BankAccountName = "Council Tax A/C",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            },
            //  Virgin ISA
            new BankAccount
            {
                BankAccountId = VirginISAAccountId,
                BankId = Banks.BankSeeding.VirginBankId,
                BankAccountName = "Virgin Money ISA",
                UKSortCode = "",
                UKBankAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserId = UserSeeding.ADMIN_USER.UserId,
                UpdatedOnUtc = DateTime.UtcNow,
                IsDeleted = false,
            });
    }
}
