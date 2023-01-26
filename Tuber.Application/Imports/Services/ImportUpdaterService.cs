using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Authentication;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Enums;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.Application.Imports.Services;
public class ImportUpdaterService : IImportUpdaterService
{
    private readonly IImportRepository _importRepo;
    private readonly ICurrentUserService _currentUserService;
    private readonly ISystemClock _dateTimeService;

    public ImportUpdaterService(
        IImportRepository importRepo,
        ICurrentUserService currentUserService,
        ISystemClock dateTimeService)
    {
        _importRepo = importRepo;
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public ServiceResult<ImportResult> Add(
        Guid bankAccountId,
        List<Import> validatedRows)
    {
        _importRepo.Clear(bankAccountId);

        var validRowCount = 0;
        var invalidRowCount = 0;
        var categorisedRowCount = 0;
        var uncategorisedRowCount = 0;

        foreach (var row in validatedRows)
        {
            if (row.ImportRowStatus == ImportRowStatus.IsValid)
                validRowCount++;
            else
                invalidRowCount++;

            if (row.CategoryId == null)
                uncategorisedRowCount++;
            else
                categorisedRowCount++;

            var import = new Import
            {
                ImportId = Guid.NewGuid(),
                InstitutionAccountId = bankAccountId,
                ImportRowNumber = row.ImportRowNumber,
                DateValueISO8601 = row.DateValueISO8601,
                DescriptionOnStatementValue = row.DescriptionOnStatementValue,
                DescriptionValue = row.DescriptionValue!.Trim(),
                ReferenceOnStatementValue = row.ReferenceOnStatementValue,
                TransactionTypeValue = row.TransactionTypeValue,
                MoneyInValue = row.MoneyInValue,
                MoneyOutValue = row.MoneyOutValue,
                BalanceOnStatementValue = row.BalanceOnStatementValue,
                SortCodeValue = row.SortCodeValue,
                AccountNumberValue = row.AccountNumberValue,
                CategoryId = row.CategoryId,
                SubcategoryId = row.SubcategoryId,
                Notes = "",
                ImportRowStatus = row.ImportRowStatus,
                ValidationFailureMessages = row.ValidationFailureMessages,
                ImportedByUserId = _currentUserService.User().UserId,
                ImportedUtc = _dateTimeService.NowUtc(),
            };

            _importRepo.Add(import);
        }

        _importRepo.SaveChanges();

        return new ServiceResult<ImportResult>(
            payload: new ImportResult()
            {
                TotalRowCount = validatedRows.Count,
                CategorisedRowCount = categorisedRowCount,
                UncategorisedRowCount = uncategorisedRowCount,
                ValidRowCount = validRowCount,
                InvalidRowCount = invalidRowCount,
            });
    }

    public ServiceResult<Import> Update(
       Guid importId,
       Guid categoryId,
       Guid? subcategoryId,
       string? notes)
    {
        var import = _importRepo.Update(importId,
            categoryId,
            subcategoryId,
            notes);

        _importRepo.SaveChanges();

        return new ServiceResult<Import>(import);
    }
}
