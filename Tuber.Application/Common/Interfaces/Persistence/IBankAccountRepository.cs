using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IInstitutionAccountRepository : IRepository<InstitutionAccount>
{
    InstitutionAccount Add(InstitutionAccount institutionAccount);
    InstitutionAccount Update(InstitutionAccount institutionAccount);
    List<InstitutionAccount> GetPaged(int pageNumber, int pageSize);
    InstitutionAccount GetById(Guid institutionAccountId);
    int CountPages(int pageSize);
}
