using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Users;
using Tuber.Domain.Models;

namespace Tuber.Persistence.InstitutionAccounts;
public static class InstitutionAccountSeeding
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
    
    public static readonly Guid TSBInstitutionAccountId = Guid.Parse("8cd1c1cf-a8e6-4148-a78c-99cd34c02997");
    
    public static readonly Guid PayPalAccountId = Guid.Parse("c8637e26759849ce89d682f2f184f540");
    
    public static readonly Guid PensionAccountId = Guid.Parse("f0781ba0-c93d-4115-8230-7329e4708c07");
    
    public static readonly Guid PrincipalityMortgageAccountId = Guid.Parse("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a");
    
    public static readonly Guid WBBSSavingsAccountId = Guid.Parse("1b0a51db-1635-4df2-9faa-7f5d6f0450f1");
   
    public static readonly Guid HondaFinanceAccountId = Guid.Parse("85a437ee-b0b4-449c-9c81-8a2b40c94feb");
    
    public static readonly Guid BupaHealthAccountId = Guid.Parse("8219473f-a6c6-44ea-b9eb-561032dd372e");
    
    public static readonly Guid AnnaInstitutionCySolCheckAccountId = Guid.Parse("6219e157-8c03-4eaa-b78f-4fde4a2b19d0");
    
    public static readonly Guid ScottishFriendlyPHIAccountId = Guid.Parse("7d516d57-1e24-4f0c-9e23-67200adabe51");
    
    public static readonly Guid EETelecomAccountId = Guid.Parse("315e3cc7-3dcd-4f16-906a-4f433df80139");
    
    public static readonly Guid CouncilTaxAccountId = Guid.Parse("bbce5ac1-da50-4ec7-8a72-3011174c649c");
    
    public static readonly Guid VirginISAAccountId = Guid.Parse("b1436024-ad18-4f15-8d24-2aba82ea12fa");


    public static void Seed(EntityTypeBuilder<InstitutionAccount> builder)
    {
        builder.HasData(
            //Co-Op
            new InstitutionAccount
            {
                InstitutionAccountId = CoOpSalaryAccountId,
                InstitutionId = Institutions.InstitutionSeeding.CoOpBankInstitutionId,
                InstitutionAccountName = "Salary",
                UKSortCode = "089191",
                UKInstitutionAccount = "09411905",
                OpeningBalance = 595.01,
                OrderBy = 10,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new InstitutionAccount
            {
                InstitutionAccountId = CoOpCashAccountId,
                InstitutionId = Institutions.InstitutionSeeding.CoOpBankInstitutionId,
                InstitutionAccountName = "Cash",
                UKSortCode = "089191",
                UKInstitutionAccount = "00985630",
                OpeningBalance = 0,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new InstitutionAccount
            {
                InstitutionAccountId = CoOpSavingsAccountId,
                InstitutionId = Institutions.InstitutionSeeding.CoOpBankInstitutionId,
                InstitutionAccountName = "Savings",
                UKSortCode = "089191",
                UKInstitutionAccount = "09405515",
                OpeningBalance = 0,
                OrderBy = 30,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.CoOpImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            // Lloyds
            new InstitutionAccount
            {
                InstitutionAccountId = Lloyds93DIXAccountId,
                InstitutionId = Institutions.InstitutionSeeding.LloydsBankInstitutionId,
                InstitutionAccountName = "Lloyds 93DIX",
                UKSortCode = "901111",
                UKInstitutionAccount = "09405515",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.LloydsImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new InstitutionAccount
            {
                InstitutionAccountId = Lloyds25PARAccountId,
                InstitutionId = Institutions.InstitutionSeeding.LloydsBankInstitutionId,
                InstitutionAccountName = "Lloyds 25PAR",
                UKSortCode = "901111",
                UKInstitutionAccount = "09405515",
                OpeningBalance = 0,
                OrderBy = 20,
                ImportTemplateId = ImportTemplates.ImportTemplateSeeding.LloydsImportTemplateId,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            //  Barclays
            new InstitutionAccount
            {
                InstitutionAccountId = BarclaysCheckAccountId,
                InstitutionId = Institutions.InstitutionSeeding.BarclaysBankInstitutionId,
                InstitutionAccountName = "Barclays Check A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
                OpeningBalance = 0,
                OrderBy = 10,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new InstitutionAccount
            {
                InstitutionAccountId = BarclaysAlexSavingsAccountId,
                InstitutionId = Institutions.InstitutionSeeding.BarclaysBankInstitutionId,
                InstitutionAccountName = "Alexs Savings A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
                OpeningBalance = 0,
                OrderBy = 20,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new InstitutionAccount
            {
                InstitutionAccountId = BarclaysEthanSavingsAccountId,
                InstitutionId = Institutions.InstitutionSeeding.BarclaysBankInstitutionId,
                InstitutionAccountName = "Ethans Savings A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
                OpeningBalance = 0,
                OrderBy = 30,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            //  TSB
            new InstitutionAccount
            {
                InstitutionAccountId = TSBInstitutionAccountId,
                InstitutionId = Institutions.InstitutionSeeding.TSBBankInstitutionId,
                InstitutionAccountName = "TSB Institution Account",
                UKSortCode = "440191",
                UKInstitutionAccount = "98765555",
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
            new InstitutionAccount
            {
                InstitutionAccountId = PayPalAccountId,
                InstitutionId = Institutions.InstitutionSeeding.PayPalInstitutionId,
                InstitutionAccountName = "PayPal",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = PensionAccountId,
                InstitutionId = Institutions.InstitutionSeeding.ScottishWidowsInstitutionId,
                InstitutionAccountName = "Scottish Widows Pension",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = PrincipalityMortgageAccountId,
                InstitutionId = Institutions.InstitutionSeeding.PrincipalityInstitutionId,
                InstitutionAccountName = "Principality Building Society",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = WBBSSavingsAccountId,
                InstitutionId = Institutions.InstitutionSeeding.WBBSInstitutionId,
                InstitutionAccountName = "West Bromwich Building Society",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = CoOpTravelCreditCardAccountId,
                InstitutionId = Institutions.InstitutionSeeding.CoOpBankInstitutionId,
                InstitutionAccountName = "Co-Op Travel Credit Card",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = HondaFinanceAccountId,
                InstitutionId = Institutions.InstitutionSeeding.HondaFinanceInstitutionId,
                InstitutionAccountName = "Honda Finance",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = BupaHealthAccountId,
                InstitutionId = Institutions.InstitutionSeeding.BupaInstitutionId,
                InstitutionAccountName = "BUPA Health A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = AnnaInstitutionCySolCheckAccountId,
                InstitutionId = Institutions.InstitutionSeeding.AnnaBankInstitutionId,
                InstitutionAccountName = "Cyrus Solutions Check A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = ScottishFriendlyPHIAccountId,
                InstitutionId = Institutions.InstitutionSeeding.ScottishFriendlyInstitutionId,
                InstitutionAccountName = "Scottish Friendly PHI A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = EETelecomAccountId,
                InstitutionId = Institutions.InstitutionSeeding.EETelecomInstitutionId,
                InstitutionAccountName = "EE Telecom A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = CouncilTaxAccountId,
                InstitutionId = Institutions.InstitutionSeeding.WorcestershireCouncilInstitutionId,
                InstitutionAccountName = "Council Tax A/C",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
            new InstitutionAccount
            {
                InstitutionAccountId = VirginISAAccountId,
                InstitutionId = Institutions.InstitutionSeeding.VirginMoneyInstitutionId,
                InstitutionAccountName = "Virgin Money ISA",
                UKSortCode = "",
                UKInstitutionAccount = "",
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
