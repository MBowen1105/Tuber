﻿using Tuber.Domain.Enums;
using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Interfaces.FileSystem;
using Tuber.Domain.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Services;
public class ImportUpdaterService : IImportUpdaterService
{
    private readonly IImportRepository _importRepo;
    private readonly IImportTemplateRetrievalService _importTemplateRetrieverService;
    private readonly IBankAccountRetrievalService _bankAccountRetrieverService;
    private readonly IFileSystem _fileIO;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTimeService;

    public ImportUpdaterService(
        IImportRepository importRepo,
        IImportTemplateRetrievalService importTemplateRetrieverService,
        IBankAccountRetrievalService bankAccountRetrieverService,
        IFileSystem fileIO,
        ICurrentUserService currentUserService,
        IDateTimeService dateTimeService)
    {
        _importRepo = importRepo;
        _importTemplateRetrieverService = importTemplateRetrieverService;
        _bankAccountRetrieverService = bankAccountRetrieverService;
        _fileIO = fileIO;
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public ServiceResult<ImportResult> Load(Guid bankAccountId, List<Import> validatedRows)
    {
        //  Check Bank Account Exists
        var bankAccountServiceResult = _bankAccountRetrieverService.GetById(bankAccountId);
        if (bankAccountServiceResult.HasFailed)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exceptionList: bankAccountServiceResult.Exceptions);
        }

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
