using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;

namespace Tuber.Application.Ledgers.Services;
public class LedgerRetrievalService : ILedgerRetrievalService
{
    private readonly ILedgerRepository _ledgerRepository;

    public LedgerRetrievalService(ILedgerRepository ledgerRepository)
    {
        _ledgerRepository = ledgerRepository;
    }

    public Guid? SuggestCategorisation(
        Guid bankAccountId, string? dateISO8601, string? description, string? reference, 
        string? moneyIn, string? moneyOut)
    {

        return _ledgerRepository.SuggestCategorisation(bankAccountId, dateISO8601,
            description, reference, moneyIn, moneyOut);
    }
}
