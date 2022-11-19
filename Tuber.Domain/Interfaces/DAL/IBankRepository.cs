using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IBankRepository : IRepository<Bank>
{
    //  Repository Commands
    Bank Add(Bank bank);
    Bank Update(Bank bank);
    int Delete(Guid id);

    //  Repository Queries
    Bank GetById(Guid id);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
