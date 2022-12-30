using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IBankAccountRetrievalService
{
    ServiceResult<List<BankAccount>> GetPaged(int pageNumber, int pageSize);
    ServiceResult<BankAccount> GetById(Guid bankAccountId);
    int CountPages(int pageSize);
}
