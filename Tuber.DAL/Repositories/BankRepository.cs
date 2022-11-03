using Tuber.Domain.Banks.Models;
using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.DAL.Repositories;
public class BankRepository : Repository<BankModel>, IBankRepository
{
    public BankRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    public int CountPages(int pageSize)
    {
        return 25;
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
