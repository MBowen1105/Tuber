using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ILedgerRetrievalService
{
    ServiceResult<Ledger> SuggestCategorisation(Guid bankAccountId,
    string? description,
    string? reference,
    double? moneyIn,
    double? moneyOut);
}
