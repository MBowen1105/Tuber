using Tuber.Domain.Dtos;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankService
{
    BankDto Add(string name, int orderBy);
    BankDto GetById(Guid id);
    List<BankDto> GetPaged(int pageNumber, int pageSize);
    BankDto Delete(Guid id);
    int CountPages(int pageSize);
}
