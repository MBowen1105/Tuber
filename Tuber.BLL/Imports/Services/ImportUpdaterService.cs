using Tuber.Domain.Enums;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Interfaces.SystemClock;
using Tuber.Domain.Interfaces.FileSystem;
using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Services;
public class ImportUpdaterService : IImportUpdaterService
{
    private readonly IImportRepository _importRepo;
    private readonly IImportTemplateRetrievalService _importTemplateRetrieverService;
    private readonly IBankAccountRetrievalService _bankAccountRetrieverService;
    private readonly IFileSystemRetrievalService _fileSystemRetrievalService;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTimeService;

    public ImportUpdaterService(
        IImportRepository importRepo,
        IImportTemplateRetrievalService importTemplateRetrieverService,
        IBankAccountRetrievalService bankAccountRetrieverService,
        IFileSystemRetrievalService fileSystemRetrievalService,
        ICurrentUserService currentUserService,
        IDateTimeService dateTimeService)
    {
        _importRepo = importRepo;
        _importTemplateRetrieverService = importTemplateRetrieverService;
        _bankAccountRetrieverService = bankAccountRetrieverService;
        _fileSystemRetrievalService = fileSystemRetrievalService;
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public ServiceResult<ImportResult> ImportFile(Guid importTemplateId, Guid bankAccountId, string importFileName)
    {
        //  Get Import Template
        var importTemplateServiceResult = _importTemplateRetrieverService.GetById(importTemplateId);
        if (!importTemplateServiceResult.IsSuccess)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exceptionList: importTemplateServiceResult.Exceptions);
        }

        var importTemplate = importTemplateServiceResult.Payload;

        //  Get Bank Account Exists
        var bankAccountServiceResult = _bankAccountRetrieverService.GetById(bankAccountId);
        if (!bankAccountServiceResult.IsSuccess)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exceptionList: bankAccountServiceResult.Exceptions);
        }

        var importFileLocation = "Tuber.Infrastructure\\FileSystem\\" + importFileName;
        var fileSystemServiceResult = _fileSystemRetrievalService.LoadTextFile(importFileLocation);
        if (!fileSystemServiceResult.IsSuccess)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exceptionList: fileSystemServiceResult.Exceptions);
        }

        var allRowsInFile = fileSystemServiceResult.Payload;
        var totalRowCount = allRowsInFile!.Count;

        //  Check for empty file.
        if (totalRowCount == 0)
        {
            return new ServiceResult<ImportResult>(
                payload: new ImportResult(),
                exception: new InvalidImportFileException(importFileLocation, "Import File is Empty"));
        }

        
        var validRowCount = 0;
        var invalidRowCount = 0;
        var abortMessage = "";
        var rowValidationExceptions = "";
        var i = 0;

        while (i < totalRowCount || abortMessage != "")
        {
            i++;

            var column = allRowsInFile[i - 1].Split(',');

            if (column.Length != importTemplate!.ExpectedColumnCount)
            {
                abortMessage = $"Expecting {importTemplate.ExpectedColumnCount} columns, but found {column.Length} at row {i}";
                continue;
            }

            //  Skip any header rows
            if (i < importTemplate.ExpectedHeaderRowCount)
                continue;

            var dateValue = column[importTemplate.DateColumnNumber - 1];

            var descriptionOnStatementValue = column[importTemplate.DescriptionOnStatementColumnNumber - 1];

            var transactionTypeValue = (importTemplate.TransactionTypeColumnNumber == 0)
                ? ""
                : column[importTemplate.TransactionTypeColumnNumber - 1];

            var moneyInValue = (importTemplate.MoneyInColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyInColumnNumber - 1];

            var moneyOutValue = (importTemplate.MoneyOutColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyOutColumnNumber - 1];

            var balanceOnStatementValue = column[importTemplate.BalanceOnStatementColumnNumber - 1];

            var sortCodeValue = (importTemplate.SortCodeColumnNumber == 0)
                ? ""
                : column[importTemplate.SortCodeColumnNumber - 1];

            var accountNumberValue = (importTemplate.AccountNumberColumnNumber == 0)
                ? ""
                : column[importTemplate.AccountNumberColumnNumber - 1];

            if (rowValidationExceptions.Length == 0)
                validRowCount++;
            else
                invalidRowCount++;

            _importRepo.Add(new Import
            {
                ImportId = Guid.NewGuid(),
                BankAccountId = bankAccountId,
                ImportRowNumber = i,
                DateValue = dateValue,
                DescriptionOnStatementValue = descriptionOnStatementValue,
                TransactionTypeValue = transactionTypeValue,
                MoneyInValue = moneyInValue,
                MoneyOutValue = moneyOutValue,
                BalanceOnStatementValue = balanceOnStatementValue,
                SortCodeValue = sortCodeValue,
                AccountNumberValue = accountNumberValue,
                ImportRowStatus = ImportRowStatus.IsValid,
                ValidationFailureMessages = rowValidationExceptions,
                ImportedByUserId = _currentUserService.User().UserId,
                ImportedUtc = _dateTimeService.UtcNow()
            });
        }

        if (abortMessage.Length == 0)
            return new ServiceResult<ImportResult>(
                payload: new ImportResult
                {
                    TotalRowCount = i,
                    ValidRowCount = validRowCount,
                    InvalidRowCount = invalidRowCount
                });

        return new ServiceResult<ImportResult>(
            payload: new ImportResult(),
            exception: new InvalidImportFileException(importFileLocation, abortMessage));
    }
}
