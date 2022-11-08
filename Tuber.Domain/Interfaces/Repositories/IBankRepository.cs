using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.Repositories;
public interface IBankRepository : IRepository<Bank>
{
    Guid Add(Bank bank);
    Bank GetById(Guid id);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
