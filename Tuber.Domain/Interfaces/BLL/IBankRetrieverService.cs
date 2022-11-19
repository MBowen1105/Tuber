using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankRetrieverService
{
    Bank GetById(Guid id);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
