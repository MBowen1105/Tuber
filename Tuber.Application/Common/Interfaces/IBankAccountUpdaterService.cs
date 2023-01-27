using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionAccountUpdaterService
{
    ServiceResult<InstitutionAccount> Add(string institutionAccountName, string UKSortCode, string UKInstitutionAccount,
        int orderBy, Guid? importTemplateId, double openingBalance);
    ServiceResult<InstitutionAccount> Update(Guid institutionAccountId, 
        string institutionAccountName, string UKSortCode, string UKInstitutionAccount,
        int orderBy, Guid? importTemplateId, double openingBalance);
}
