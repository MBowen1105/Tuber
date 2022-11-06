using Tuber.Domain.Banks.Models;
using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.DAL.Repositories;
public class BankRepository : Repository<BankModel>, IBankRepository
{
    public BankRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    public List<BankModel> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<BankModel>()
            .Where(x => x.IsArchived == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<BankModel>()
            .Count(x => x.IsArchived == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
