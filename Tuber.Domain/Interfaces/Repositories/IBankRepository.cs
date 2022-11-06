using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.Repositories;
public interface IBankRepository : IRepository<Bank>
{
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
