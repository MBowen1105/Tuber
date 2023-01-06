using System;
using System.Text;
using Tuber.Application.Common;
using Tuber.Application.Common.DateRanges;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Interfaces.SystemClock;

namespace Tuber.Application.Ledgers.Services;
public class LedgerRetrievalService : ILedgerRetrievalService
{
    private readonly ILedgerRepository _ledgerRepository;
    private readonly ISystemClock _systemClock;
    private const int HorizonDays = 60;

    public LedgerRetrievalService(ILedgerRepository ledgerRepository,
        ISystemClock systemClock)
    {
        _ledgerRepository = ledgerRepository;
        _systemClock = systemClock;
    }

    public ServiceResult<Guid?> SuggestCategorisation(
        Guid bankAccountId, string? description, string? reference,
        double? moneyIn, double? moneyOut)
    {
        //  List all live transactions 40 days old or less.
        var toDate = _systemClock.Today();
        var fromDate = toDate.AddDays(-(int)DateTime.Today.DayOfWeek).AddDays(HorizonDays);

        var ledgerTransactionList = _ledgerRepository.GetBetweenDates(bankAccountId, fromDate, toDate);

        var resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.CategorySubcategoryId != null
                && x.Description == description
                && x.Reference == reference
                && x.MoneyIn == moneyIn
                && x.MoneyOut == moneyOut)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Guid?>(resultList.First().CategorySubcategoryId);

        resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.CategorySubcategoryId != null
                && x.Description == description
                && x.Reference == reference)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Guid?>(resultList.First().CategorySubcategoryId);

        resultList = ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.CategorySubcategoryId != null
                && x.Description == description)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Guid?>(resultList.First().CategorySubcategoryId);

        return new ServiceResult<Guid?>(null);
    }
}
