using Tuber.Domain.Dtos;

namespace Tuber.Domain.Interfaces.Services;
public interface IBankService
{
    List<BankDto> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
