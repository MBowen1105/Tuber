using Tuber.Core.Validation;
using Tuber.Domain.Enums;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Services;
public class ImportValidationService : IImportValidationService
{
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTimeService;

    public ImportValidationService(ICurrentUserService currentUserService, IDateTimeService dateTimeService)
    {
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public ServiceResult<List<Import>> Validate(
        ImportTemplate importTemplate,
        Guid bankAccountId,
        string[] allRows)
    {
        //  Check the first row of the array against the expected number of columns
        var cols = allRows[0].Split(importTemplate.SeperatorChar);

        if (cols.Length != importTemplate.ExpectedColumnCount)
        {
            return new ServiceResult<List<Import>>(
                new List<Import>(),
                new InvalidImportFileException("",
                    $"Expected {importTemplate.ExpectedColumnCount} columns, but found {cols.Length}.")
                );
        }

        var i = 0;
        var rowIndex = 0;
        var validatedRows = new List<Import>();
        var previousDateValue = "";

        while (i < allRows.Length)
        {
            i++;

            var column = allRows[i - 1].Split(',');

            //  Skip any header rows
            if (i <= importTemplate.ExpectedHeaderRowCount)
                continue;

            string? validationFailureMessages = "";

            var dateValue = column[importTemplate.DateColumnNumber - 1];
            if (dateValue.Length == 0)
                validationFailureMessages += $"Transaction Date is missing.\n";

            if (!DateTimeValidation.IsValidDate(dateValue, importTemplate.DateTemplate))
            {
                validationFailureMessages += $"Transaction Date is invalid. Must be of the format {importTemplate.DateTemplate}.\n";
            }
            else
            {
                //  Transform value dates into ISO8601 format
                dateValue = DateTimeValidation.ToISO8601(dateValue, importTemplate.DateTemplate);
            }

            var descriptionOnStatementValue = column[importTemplate.DescriptionOnStatementColumnNumber - 1];
            if (descriptionOnStatementValue.Length > 40)
                validationFailureMessages += $"Description on statement cannot exceed 40 character - truncating\n";

            var transactionTypeValue = (importTemplate.TransactionTypeColumnNumber == 0)
                ? ""
                : column[importTemplate.TransactionTypeColumnNumber - 1];
            if (descriptionOnStatementValue.Length > 10)
                validationFailureMessages += $"Transaction Type cannot exceed 40 character - truncating\n";

            var moneyInValue = (importTemplate.MoneyInColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyInColumnNumber - 1];
            if (moneyInValue != "" && !double.TryParse(moneyInValue, out _))
                validationFailureMessages = "Invalid Money In value. Must be a valid amount.\n";

            var moneyOutValue = (importTemplate.MoneyOutColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyOutColumnNumber - 1];
            if (moneyOutValue != "" && !double.TryParse(moneyOutValue, out _))
                validationFailureMessages = "Invalid Money Out value. Must be a valid amount.\n";

            if (moneyInValue == "" && moneyOutValue == "")
                validationFailureMessages += "This transaction has no Money In or Money Out value.\n";
            
            var balanceOnStatementValue = column[importTemplate.BalanceOnStatementColumnNumber - 1];
            if (!double.TryParse(balanceOnStatementValue, out _))
                validationFailureMessages += "Balance on Statement value is not a valid amount.\n";
                
            var sortCodeValue = (importTemplate.SortCodeColumnNumber == 0)
                ? ""
                : column[importTemplate.SortCodeColumnNumber - 1];
            if (sortCodeValue.Length > 10)
                validationFailureMessages += "Sort Code cannot exceed 10 characters.\n";

            var accountNumberValue = (importTemplate.AccountNumberColumnNumber == 0)
                ? ""
                : column[importTemplate.AccountNumberColumnNumber - 1];
            if (accountNumberValue.Length>10)
                validationFailureMessages += "Account Number cannot exceed 10 characters.\n";

            rowIndex = (previousDateValue == dateValue)
              ? rowIndex++
              : 1;
            previousDateValue = dateValue;

            validatedRows.Add(new Import
            {
                BankAccountId = bankAccountId,
                ImportRowNumber = rowIndex,
                DateValue = dateValue,
                DescriptionOnStatementValue = descriptionOnStatementValue,
                TransactionTypeValue = transactionTypeValue,
                MoneyInValue = moneyInValue,
                MoneyOutValue = moneyOutValue,
                BalanceOnStatementValue = balanceOnStatementValue,
                SortCodeValue = sortCodeValue,
                AccountNumberValue = accountNumberValue,
                ImportRowStatus = ImportRowStatus.IsValid,
                ValidationFailureMessages = validationFailureMessages,
                ImportedByUserId = _currentUserService.User().UserId,
                ImportedUtc = _dateTimeService.UtcNow()
            });
        }

        return new ServiceResult<List<Import>>(
            payload: validatedRows);
    }
}
