namespace Tuber.Application.Common.Interfaces;
public interface ILedgerRetrievalService
{
    ServiceResult<Guid?> SuggestCategorisation(Guid bankAccountId,
    string? description,
    string? reference,
    double? moneyIn,
    double? moneyOut);
}
