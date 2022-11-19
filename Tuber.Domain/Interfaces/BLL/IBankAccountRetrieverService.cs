using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankAccountRetrieverService
{
    List<BankAccount> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
