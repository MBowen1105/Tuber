using Tuber.Domain.Models;
using Tuber.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Tuber.DAL.Repositories;
public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
{
    public BankAccountRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<BankAccount>()
            .Include(x => x.Bank)
            .Where(x => x.IsArchived == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<BankAccount>()
            .Count(x => x.IsArchived == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
