using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Services;
public class LedgerRetrievalService : ILedgerRetrievalService
{
    private readonly ILedgerRepository _ledgerRepository;
    private readonly ISystemClock _systemClock;
    private const int HorizonDays = 365;

    public LedgerRetrievalService(
        ILedgerRepository ledgerRepository,
        ISystemClock systemClock)
    {
        _ledgerRepository = ledgerRepository;
        _systemClock = systemClock;
    }

    public ServiceResult<Ledger> SuggestCategorisation(
        Guid bankAccountId, string? description, string? reference,
        double? moneyIn, double? moneyOut)
    {
        //  List all live transactions 40 days old or less.
        var toDate = _systemClock.TodayUtc();
        var fromDate = toDate.AddDays(-HorizonDays).AddDays(-1).AddSeconds(1);

        var ledgerTransactionList = _ledgerRepository.GetBetweenDates(bankAccountId,
            fromDate, toDate);

        var resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.BankAccountId == bankAccountId
                && x.Description == description
                && x.Reference == reference
                && x.MoneyIn == moneyIn
                && x.MoneyOut == moneyOut
                && x.CategorySubcategoryId != null)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.BankAccountId == bankAccountId
                && x.Description == description
                && x.Reference == reference
                && x.CategorySubcategoryId != null)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.BankAccountId == bankAccountId
                && x.Description == description
                && x.CategorySubcategoryId != null)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        return new ServiceResult<Ledger>(new Ledger());
    }
}
