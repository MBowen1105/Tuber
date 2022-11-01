using Tuber.Domain.Banks.Models;

namespace Tuber.Domain.DAL;
public interface IBankRepo
{
    List<BankDto> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
