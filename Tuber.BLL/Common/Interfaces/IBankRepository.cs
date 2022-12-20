using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IBankRepository : IRepository<Bank>
{
    //  Repository Commands
    Bank Add(Bank bank);
    Bank Update(Bank bank);
    int Delete(Guid bankId);

    //  Repository Queries
    Bank GetById(Guid bankId);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
