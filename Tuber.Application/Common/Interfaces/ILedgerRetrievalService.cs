using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ILedgerRetrievalService
{
    ServiceResult<Ledger> SuggestCategorisation(Guid bankAccountId,
    string? description,
    string? reference,
    double? moneyIn,
    double? moneyOut);

    ServiceResult<List<Ledger>> GetPaged(Guid bankAccountId, int pageNumber, int pageSize);

    int CountPages(int pageSize);
}
