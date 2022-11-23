using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.BankAccounts;
public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
{
    public BankAccountRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<BankAccount>()
            .Where(x => x.IsDeleted == true)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<BankAccount>()
            .Count(x => x.IsDeleted == true);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
