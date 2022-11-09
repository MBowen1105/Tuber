using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IBankAccountRepository : IRepository<BankAccount>
{
    List<BankAccount> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
