using Tuber.DAL.Repositories;
using Tuber.Domain.Interfaces;
using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.DAL;
public class UnitOfWork : IUnitOfWork
{
    public IBankRepository Banks { get; private set; }

    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Banks = new BankRepository(_context);
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }
    public void Dispose()
    {
        _context.Dispose();
    }

}
