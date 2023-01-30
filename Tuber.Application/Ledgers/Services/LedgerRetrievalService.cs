using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Common.Interfaces.Clock;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Services;
public class LedgerRetrievalService : ILedgerRetrievalService
{
    private readonly ILedgerRepository _ledgerRepo;
    private readonly IAppConfigRepository _appConfigRepo;

    private readonly IClock _systemClock;

    private List<Ledger> _ledgerTransactionList = new();
    private Guid _currentInstitutionAccountId = Guid.Empty;



    public LedgerRetrievalService(
        ILedgerRepository ledgerRepository,
        IAppConfigRepository appConfigRepo,
        IClock systemClock)
    {
        _ledgerRepo = ledgerRepository;
        _appConfigRepo = appConfigRepo;
        _systemClock = systemClock;
    }

    public ServiceResult<Ledger> SuggestCategorisation(
        Guid bankAccountId, string? description, string? reference,
        double? moneyIn, double? moneyOut)
    {
        if (_currentInstitutionAccountId != bankAccountId)
        {
            var settings = _appConfigRepo.Get();
            var toDate = _systemClock.TodayUtc();
            var fromDate = toDate.AddDays(-settings.CategorySuggestionHorizonDays)
                .AddDays(-1).AddSeconds(1);

            _ledgerTransactionList = _ledgerRepo.GetBetweenDates(bankAccountId,
                fromDate, toDate);
        }

        _currentInstitutionAccountId = bankAccountId;

        var resultList = _ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.InstitutionAccountId == bankAccountId
                && x.Description == description
                && x.Reference == reference
                && x.MoneyIn == moneyIn
                && x.MoneyOut == moneyOut)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        resultList = _ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.InstitutionAccountId == bankAccountId
                && x.Description == description
                && x.Reference == reference)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        resultList = _ledgerTransactionList
            .OrderByDescending(x => x.DateUtc)
            .Where(x => x.InstitutionAccountId == bankAccountId
                && x.Description == description)
            .ToList();

        if (resultList.Any())
            return new ServiceResult<Ledger>(resultList.First());

        return new ServiceResult<Ledger>(new Ledger());
    }

    public ServiceResult<List<Ledger>> GetPaged(
        Guid bankAccountId,
        int pageNumber, int
        pageSize)
    {
        var ledgerList = _ledgerRepo.GetPaged(bankAccountId, pageNumber, pageSize);
        return new ServiceResult<List<Ledger>>(ledgerList);
    }

    public int CountPages(int pageSize) =>
        _ledgerRepo.CountPages(pageSize);
}
