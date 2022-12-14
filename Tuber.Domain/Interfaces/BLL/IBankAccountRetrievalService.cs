using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankAccountRetrievalService
{
    ServiceResult<List<BankAccount>> GetPaged(int pageNumber, int pageSize);
    ServiceResult<BankAccount> GetById(Guid bankAccountId);
    int CountPages(int pageSize);
}
