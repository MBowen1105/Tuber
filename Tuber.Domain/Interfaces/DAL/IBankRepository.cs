using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IBankRepository : IRepository<Bank>
{
    Bank Add(Bank bank);
    Bank GetById(Guid id);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    Bank Delete(Guid id);
    int CountPages(int pageSize);
}
