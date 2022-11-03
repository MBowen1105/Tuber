using Tuber.Domain.Banks.Models;
using Tuber.Domain.Repositories.Interfaces;

namespace Tuber.Domain.Interfaces.Repositories;
public interface IBankRepository : IRepository<BankModel>
{
    int CountPages(int pageSize);
}
