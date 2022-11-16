using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Tuber.Domain.Interfaces.DAL;
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
            .Include(x => x.BankAccounts)
            .FirstOrDefault(x => x.Id == id && x.IsArchived == false);

        return (bank ?? new Bank { Id = Guid.Empty });
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<Bank>()
            .Include(x => x.BankAccounts)
            .Where(x => x.IsArchived == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public Bank Add(Bank bank)
    {
        _context.Set<Bank>()
            .Add(bank);

        return bank;
    }

    public Bank Delete(Guid id)
    {
        var bank = _context.Set<Bank>()
            .Include(x => x.BankAccounts)
            .Single(x => x.Id == id && x.IsArchived == false);

        if (bank == null)
            return new Bank { Id = Guid.Empty };

        bank.IsArchived = true;

        foreach (var bankAccount in bank.BankAccounts!)
        {
            bankAccount.IsArchived = true;
        }

        _context.SaveChanges();

        return bank;
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<Bank>()
            .Count(x => x.IsArchived == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }
}
