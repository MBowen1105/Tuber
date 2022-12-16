using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IBankAccountRepository : IRepository<BankAccount>
{
    List<BankAccount> GetPaged(int pageNumber, int pageSize);
    BankAccount GetById(Guid bankAccountId);
    BankAccount Add(BankAccount bankAccount);
    BankAccount Update(BankAccount bankAccount);
    int Delete(Guid bankAccountId);
    int CountPages(int pageSize);
}
