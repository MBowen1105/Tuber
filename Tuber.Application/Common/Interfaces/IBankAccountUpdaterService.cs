using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionAccountUpdaterService
{
    ServiceResult<InstitutionAccount> Add(string bankAccountName, int orderBy);
    ServiceResult<InstitutionAccount> Update(Guid bankAccountId, string bankAccountName, int orderBy);
}
