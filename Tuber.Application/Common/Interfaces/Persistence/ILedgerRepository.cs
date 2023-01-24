using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ILedgerRepository : IRepository<Ledger>
{
    //  Repository Commands
    Ledger Add(Ledger ledger);
    Ledger Update(Ledger ledger);

    //  Repository Queries
    List<Ledger> GetBetweenDates(Guid bankAccountId, DateTime fromDate, DateTime toDate);

    Ledger GetByValues(Guid bankAccountId, DateTime dateUtc, string description, double? moneyIn, double? moneyOut);
    List<Ledger> GetPaged(Guid bankAccountId, int pageNumber, int pageSize);
    int NextRowNumber(Guid bankAccountId, DateTime dateUtc);
    int CountPages(int pageSize);
}
