namespace Tuber.Application.Common.Interfaces;
public interface ILedgerRetrievalService
{
    Guid? SuggestCategorisation(Guid bankAccountId,
    string? dateISO8601,
    string? description,
    string? reference,
    string? moneyIn,
    string? moneyOut);
}
