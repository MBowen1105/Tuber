using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Authentication;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Enums;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Application.Models;

namespace Tuber.Application.Imports.Services;
public class ImportUpdaterService : IImportUpdaterService
{
    private readonly IImportRepository _importRepo;
    private readonly IBankAccountRetrievalService _bankAccountRetrieverService;
    private readonly ICurrentUserService _currentUserService;
    private readonly ISystemClock _dateTimeService;

    public ImportUpdaterService(
        IImportRepository importRepo,
        IBankAccountRetrievalService bankAccountRetrieverService,
        ICurrentUserService currentUserService,
        ISystemClock dateTimeService)
    {
        _importRepo = importRepo;
        _bankAccountRetrieverService = bankAccountRetrieverService;
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public ServiceResult<ImportResult> Add(Guid bankAccountId, List<Import> validatedRows)
    {
        //  Check Bank Account Exists
        var bankAccountServiceResult = _bankAccountRetrieverService.GetById(bankAccountId);
        if (bankAccountServiceResult.HasFailed)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exceptionList: bankAccountServiceResult.Exceptions);
        }

        _importRepo.Clear(bankAccountId);

        var validRowCount = 0;
        var invalidRowCount = 0;

        foreach (var row in validatedRows)
        {
            if (row.ImportRowStatus == ImportRowStatus.IsValid)
                validRowCount++;
            else
                invalidRowCount++;

            _importRepo.Add(new Import
            {
                ImportId = Guid.NewGuid(),
                BankAccountId = bankAccountId,
                ImportRowNumber = row.ImportRowNumber,
                DateValue = row.DateValue,
                DescriptionOnStatementValue = row.DescriptionOnStatementValue,
                DescriptionValue = row.DescriptionValue!.Trim(),
                ReferenceOnStatementValue = row.ReferenceOnStatementValue,
                TransactionTypeValue = row.TransactionTypeValue,
                MoneyInValue = row.MoneyInValue,
                MoneyOutValue = row.MoneyOutValue,
                BalanceOnStatementValue = row.BalanceOnStatementValue,
                SortCodeValue = row.SortCodeValue,
                AccountNumberValue = row.AccountNumberValue,
                ImportRowStatus = row.ImportRowStatus,
                ValidationFailureMessages = row.ValidationFailureMessages,
                ImportedByUserId = _currentUserService.User().UserId,
                ImportedUtc = _dateTimeService.UtcNow()
            });
        }

        _importRepo.SaveChanges();

        return new ServiceResult<ImportResult>(
            payload: new ImportResult()
            {
                TotalRowCount = validatedRows.Count,
                ValidRowCount = validRowCount,
                InvalidRowCount = invalidRowCount,
            });
    }


}
