using Tuber.Domain.Interfaces.Repositories;
using Tuber.Domain.Models;

namespace Tuber.DAL.Repositories;
public class BankRepository : Repository<Bank>, IBankRepository
{
    public BankRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    public Bank GetById(Guid id)
    {
        var bank = _context.Set<Bank>()
             .FirstOrDefault(x => x.Id == id && x.IsArchived == false);

        return (bank ?? new Bank { Id = Guid.Empty });
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<Bank>()
            .Where(x => x.IsArchived == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public Guid Add(Bank bank)
    {
        _context.Set<Bank>()
            .Add(bank);
        return bank.Id;
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<Bank>()
            .Count(x => x.IsArchived == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }
}
