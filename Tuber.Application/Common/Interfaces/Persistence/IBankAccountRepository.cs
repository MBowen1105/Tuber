using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IBankAccountRepository : IRepository<BankAccount>
{
    BankAccount Add(BankAccount bankAccount);
    BankAccount Update(BankAccount bankAccount);
    List<BankAccount> GetPaged(int pageNumber, int pageSize);
    BankAccount GetById(Guid bankAccountId);
    int CountPages(int pageSize);
}
