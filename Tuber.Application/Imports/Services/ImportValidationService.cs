using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Authentication;
using Tuber.Application.Enums;
using Tuber.Application.Exceptions;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Domain.Models;
using Tuber.Core.Validation;

namespace Tuber.Application.Imports.Services;
public class ImportValidationService : IImportValidationService
{
    public static readonly char ValidationMessageSeperator = '\n';

    private readonly ICurrentUserService _currentUserService;
    private readonly ISystemClock _dateTimeService;
    private readonly ILedgerRetrievalService _ledgerRetrievalService;
    private readonly IBankAccountRetrievalService _bankAccountRetrievalService;

    public ImportValidationService(
        ICurrentUserService currentUserService,
        ISystemClock dateTimeService,
        ILedgerRetrievalService transactionRetrievalService,
        IBankAccountRetrievalService bankAccountRetrievalService)
    {
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
        _ledgerRetrievalService = transactionRetrievalService;
        _bankAccountRetrievalService = bankAccountRetrievalService;
    }

    public ServiceResult<List<Import>> Validate(
        ImportTemplate importTemplate,
        Guid bankAccountId,
        bool suggestCategorisation,
        string[] allRows)
    {
        //  Check Bank Account Exists
        var bankAccountServiceResult = _bankAccountRetrievalService.GetById(bankAccountId);
        if (bankAccountServiceResult.HasFailed)
        {
            return new ServiceResult<List<Import>>(
                payload: new List<Import>(),
                exceptionList: bankAccountServiceResult.Exceptions);
        }

        var bankAccount = bankAccountServiceResult.Payload;

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
        var moneyIn = 0.0;
        var moneyOut = 0.0;
        var validDateISO8601Value = "";

        while (i < allRows.Length)
        {
            i++;

            var column = allRows[i - 1].Split(importTemplate.SeperatorChar);

            //  Skip any header rows
            if (i <= importTemplate.ExpectedHeaderRowCount)
                continue;

            string? validationFailureMessages = "";

            var dateValue = column[importTemplate.DateColumnNumber - 1];
            if (dateValue.Length == 0)
                validationFailureMessages += $"Transaction Date is missing.{ValidationMessageSeperator}";

            if (!DateTimeValidation.IsValidDate(dateValue, importTemplate.DateTemplate))
            {
                validationFailureMessages += $"Transaction Date is invalid. Must be of the format {importTemplate.DateTemplate}.{ValidationMessageSeperator}";
            }
            else
            {
                //  Transform value dates into ISO8601 format
                validDateISO8601Value = DateTimeValidation.ToISO8601(dateValue, importTemplate.DateTemplate);
            }

            var descriptionOnStatementValue = column[importTemplate.DescriptionOnStatementColumnNumber - 1];
            if (descriptionOnStatementValue.Length > 40)
                validationFailureMessages += $"Description on statement cannot exceed 40 character - truncating.{ValidationMessageSeperator}";

            if (descriptionOnStatementValue.Length == 0)
                validationFailureMessages += $"Description on statement is missing.{ValidationMessageSeperator}";

            var referenceOnStatementValue = "";
            if (importTemplate.ReferenceOnStatementStartCharacter > 0 && descriptionOnStatementValue.Length >= importTemplate.ReferenceOnStatementStartCharacter)
                referenceOnStatementValue = descriptionOnStatementValue[importTemplate.ReferenceOnStatementStartCharacter..];
            referenceOnStatementValue = referenceOnStatementValue.TrimEnd();

            var descriptionValue = descriptionOnStatementValue;
            if (importTemplate.ReferenceOnStatementStartCharacter > 0)
            {
                var n = (importTemplate.ReferenceOnStatementStartCharacter > descriptionOnStatementValue.Length)
                    ? descriptionOnStatementValue.Length
                    : importTemplate.ReferenceOnStatementStartCharacter - 1;
                descriptionValue = descriptionOnStatementValue[..n];
            }
            descriptionValue = descriptionValue.TrimEnd();

            var transactionTypeValue = (importTemplate.TransactionTypeColumnNumber == 0)
                ? ""
                : column[importTemplate.TransactionTypeColumnNumber - 1];
            if (transactionTypeValue.Length > 10)
                validationFailureMessages += $"Transaction Type cannot exceed 10 characters - truncating.{ValidationMessageSeperator}";

            var moneyInValue = (importTemplate.MoneyInColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyInColumnNumber - 1];

            if (moneyInValue != "" && !double.TryParse(moneyInValue, out moneyIn))
                validationFailureMessages = $"Invalid Money In value. Must be a valid amount.{ValidationMessageSeperator}";
            else if (moneyInValue != "" && moneyIn < 0.0)
                validationFailureMessages = $"Money In value cannot be negative.{ValidationMessageSeperator}";
            else if (moneyInValue != "" && moneyIn == 0.0)
                validationFailureMessages = $"Money In value cannot be zero.{ValidationMessageSeperator}";

            var moneyOutValue = (importTemplate.MoneyOutColumnNumber == 0)
                ? ""
                : column[importTemplate.MoneyOutColumnNumber - 1];
            if (moneyOutValue != "" && !double.TryParse(moneyOutValue, out moneyOut))
                validationFailureMessages = $"Invalid Money Out value. Must be a valid amount.{ValidationMessageSeperator}";
            else if (moneyOutValue != "" && moneyOut < 0.0)
                validationFailureMessages = $"Money Out value cannot be negative.{ValidationMessageSeperator}";
            else if (moneyOutValue != "" && moneyOut == 0.0)
                validationFailureMessages = $"Money Out value cannot be zero.{ValidationMessageSeperator}";

            if (moneyInValue == "" && moneyOutValue == "")
                validationFailureMessages += $"This transaction has no Money In or Money Out value.{ValidationMessageSeperator}";

            var balanceOnStatementValue = column[importTemplate.BalanceOnStatementColumnNumber - 1];
            if (balanceOnStatementValue.Length == 0)
                validationFailureMessages += $"Balance on Statement is missing.{ValidationMessageSeperator}";
            else
            if (!double.TryParse(balanceOnStatementValue, out _))
                validationFailureMessages += $"Balance on Statement value is not a valid amount.{ValidationMessageSeperator}";

            var sortCodeValue = (importTemplate.SortCodeColumnNumber == 0)
                ? ""
                : column[importTemplate.SortCodeColumnNumber - 1];
            if (sortCodeValue.Length > 10)
                validationFailureMessages += $"Sort Code cannot exceed 10 characters.{ValidationMessageSeperator}";

            var accountNumberValue = (importTemplate.AccountNumberColumnNumber == 0)
                ? ""
                : column[importTemplate.AccountNumberColumnNumber - 1];
            if (accountNumberValue.Length > 10)
                validationFailureMessages += $"Account Number cannot exceed 10 characters.{ValidationMessageSeperator}";

            if (validationFailureMessages.EndsWith(ValidationMessageSeperator))
                validationFailureMessages = validationFailureMessages[..^1];

            Guid? suggestedCategoryId = null;
            Guid? suggestedSubcategoryId = null;
            if (suggestCategorisation)
            {
                var suggestCategorisationServiceResult = _ledgerRetrievalService.SuggestCategorisation(
                    bankAccountId, descriptionValue, referenceOnStatementValue,
                    moneyIn, moneyOut);
                suggestedCategoryId = suggestCategorisationServiceResult.Payload.CategoryId;
                suggestedSubcategoryId = suggestCategorisationServiceResult.Payload.SubcategoryId;
            }

            if (previousDateValue == dateValue)
                rowIndex++;
            else
            {
                rowIndex = 1;
                previousDateValue = dateValue;
            }
            var newImportRow = new Import
            {
                BankAccountId = bankAccountId,
                ImportRowNumber = rowIndex,
                DateValueISO8601 = validDateISO8601Value,
                DescriptionOnStatementValue = descriptionOnStatementValue,
                DescriptionValue = descriptionValue,
                ReferenceOnStatementValue = referenceOnStatementValue,
                TransactionTypeValue = transactionTypeValue,
                MoneyInValue = moneyInValue,
                MoneyOutValue = moneyOutValue,
                BalanceOnStatementValue = balanceOnStatementValue,
                SortCodeValue = sortCodeValue,
                AccountNumberValue = accountNumberValue,
                CategoryId = suggestedCategoryId,
                SubcategoryId = suggestedSubcategoryId,
                ImportRowStatus = (validationFailureMessages.Length == 0)
                    ? ImportRowStatus.IsValid
                    : ImportRowStatus.IsInvalid,
                ValidationFailureMessages = validationFailureMessages,
                ImportedByUserId = _currentUserService.User().UserId,
                ImportedUtc = _dateTimeService.NowUtc(),
                //BankAccount = bankAccount,
            };
            validatedRows.Add(newImportRow);
        }

        return new ServiceResult<List<Import>>(
            payload: validatedRows);
    }
}
