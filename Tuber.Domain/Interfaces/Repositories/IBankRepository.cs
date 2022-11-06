using Tuber.Domain.Banks.Models;
using Tuber.Domain.Repositories.Interfaces;

namespace Tuber.Domain.Interfaces.Repositories;
public interface IBankRepository : IRepository<BankModel>
{
    List<BankModel> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
