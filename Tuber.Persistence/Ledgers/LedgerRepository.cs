using Tuber.Application.Common.Interfaces.Persistence;

namespace Tuber.Persistence.Ledgers;
public class LedgerRepository : ILedgerRepository
{
    private readonly ApplicationDbContext _context;

    public LedgerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Guid? SuggestCategorisation(Guid bankAccountId, string? dateISO8601,
        string? description, string? reference, string? moneyIn, string? moneyOut)
    {
        //  Look for matches from the most specific to the least specific

        //  Is there an exact match in this ledger?
        return null;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

}
