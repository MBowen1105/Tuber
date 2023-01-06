using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Ledgers;
public class LedgerRepository : ILedgerRepository
{
    private readonly ApplicationDbContext _context;

    public LedgerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Ledger> GetBetweenDates(
        Guid bankAccountId, DateTime fromDate, DateTime toDate)
    {
        return _context.Ledgers
            .Where(x => x.BankAccountId == bankAccountId &&
                x.DateUtc >= fromDate && x.DateUtc <= toDate)
            .ToList();
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

}
