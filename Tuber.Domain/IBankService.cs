using Tuber.Domain.Banks.Models;

namespace Tuber.Domain;
public interface IBankService
{
    List<BankDto> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
