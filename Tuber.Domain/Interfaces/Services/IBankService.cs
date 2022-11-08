using Tuber.Domain.Dtos;

namespace Tuber.Domain.Interfaces.Services;
public interface IBankService
{
    Guid Add(string name, int orderBy);
    BankDto GetById(Guid id);
    List<BankDto> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
