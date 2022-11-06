using Tuber.Domain.Dtos;

namespace Tuber.Domain.Interfaces.Services;
public interface IBankAccountService
{
    List<BankAccountDto> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
