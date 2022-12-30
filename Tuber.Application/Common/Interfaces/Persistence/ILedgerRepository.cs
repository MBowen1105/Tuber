using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ILedgerRepository : IRepository<Ledger>
{
    //  Repository Commands

    //  Repository Queries
    Guid? SuggestCategorisation(
         Guid bankAccountId, string? dateISO8601, string? description, string? reference,
         string? moneyIn, string? moneyOut);
}
