using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Extensions;
using Tuber.Domain.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Tuber.Persistence.Ledgers;
public class LedgerRepository : ILedgerRepository
{
    private readonly ApplicationDbContext _context;

    public LedgerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Ledger Add(Ledger ledger)
    {
        try
        {
            _context.Ledgers.Add(ledger);
        }
        catch (Exception)
        {
            //  Return a null Ledger object
            ledger = new Ledger();
        }
        return ledger;
    }

    public Ledger Update(Ledger pLedger)
    {
        var ledger = _context.Ledgers
            .FirstOrDefault(x => x.LedgerId == pLedger.LedgerId && x.IsDeleted == false);

        if (ledger is null)
            return new Ledger();

        ledger.DateUtc = pLedger.DateUtc;
        ledger.Description = pLedger.Description;
        ledger.Reference = pLedger.Reference;
        ledger.TransactionType = pLedger.TransactionType;
        ledger.MoneyIn = pLedger.MoneyIn;
        ledger.MoneyOut = pLedger.MoneyOut;
        ledger.Balance = pLedger.Balance;
        ledger.CategorySubcategoryId = pLedger.CategorySubcategoryId;

        return ledger;
    }
    #endregion

    #region "Queries"
    public List<Ledger> GetPaged(Guid bankAccountId, int pageNumber, int pageSize)
    {
        return _context.Ledgers
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .OrderBy(x => x.DateUtc)
            .ThenBy(x => x.RowNumber)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Ledgers
            .Count(x => x.IsDeleted == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    public List<Ledger> GetBetweenDates(
        Guid bankAccountId, DateTime fromDate, DateTime toDate)
    {
        return _context.Ledgers
            .Where(x => x.BankAccountId == bankAccountId &&
                x.DateUtc >= fromDate && x.DateUtc <= toDate)
            .ToList();
    }

    public Ledger GetByValues(Guid bankAccountId, DateTime dateUtc, string description, double? moneyIn, double? moneyOut)
    {
        var ledger = _context.Ledgers
        .FirstOrDefault(x => x.BankAccountId == bankAccountId &&
                x.DateUtc == dateUtc &&
                x.Description == description &&
                x.MoneyIn == moneyIn &&
                x.MoneyOut == moneyOut);

        return ledger ?? new Ledger();
    }
    #endregion


    public int SaveChanges()
    {
        return _context.SaveChanges();
    }


}
