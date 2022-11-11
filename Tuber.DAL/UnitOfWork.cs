using Tuber.DAL.Repositories;
using Tuber.Domain.Interfaces.DAL;

namespace Tuber.DAL;
public class UnitOfWork : IUnitOfWork
{
    public IBankRepository Banks { get; private set; }
    public IBankAccountRepository BankAccounts { get; private set; }

    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;

        Banks = new BankRepository(_context);
        BankAccounts = new BankAccountRepository(_context);
    }

    public Task<int> Complete()
    {
        return _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }

}
