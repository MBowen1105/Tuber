using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IInstitutionAccountRepository : IRepository<InstitutionAccount>
{
    InstitutionAccount Add(InstitutionAccount bankAccount);
    InstitutionAccount Update(InstitutionAccount bankAccount);
    List<InstitutionAccount> GetPaged(int pageNumber, int pageSize);
    InstitutionAccount GetById(Guid bankAccountId);
    int CountPages(int pageSize);
}
