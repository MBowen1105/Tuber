using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Services;
public class LedgerUpdaterService : ILedgerUpdaterService
{
    private readonly ILedgerRepository _ledgerRepo;

    public LedgerUpdaterService(
        ILedgerRepository ledgerRepo)
    {
        _ledgerRepo = ledgerRepo;
    }

    public ServiceResult<AcceptResult> Accept(Guid bankAccountId, List<Import> imports)
    {
        var createdCount = 0;
        var updatedCount = 0;
        var alreadyReconciledCount = 0;

        foreach (var import in imports)
        {
            var dateTimeValue = new DateTime(
                    int.Parse(import.DateValueISO8601![..4]),
                    int.Parse(import.DateValueISO8601.Substring(4, 2)),
                    int.Parse(import.DateValueISO8601.Substring(6, 2)));

            double? moneyIn = (string.IsNullOrEmpty(import.MoneyInValue))
                ? null
                : double.Parse(import.MoneyInValue);

            double? moneyOut = (string.IsNullOrEmpty(import.MoneyOutValue))
                ? null
                : double.Parse(import.MoneyOutValue);

            var ledger = new Ledger
            {
                BankAccountId = import.BankAccountId,
                DateUtc = dateTimeValue,
                RowNumber = import.ImportRowNumber,
                Description = import.DescriptionValue!,
                Reference = import.ReferenceOnStatementValue!,
                TransactionType = import.TransactionTypeValue!,
                MoneyIn = moneyIn,
                MoneyOut = moneyOut,
                CategoryId = (Guid)import.CategoryId!,
                SubcategoryId = import.SubcategoryId
            };

            //  Is there an EXACT matching transaction on this ledger?
            var existingLedger = _ledgerRepo.GetByValues(
                ledger.BankAccountId, ledger.DateUtc, 
                ledger.Description, ledger.MoneyIn, ledger.MoneyOut);
            
            if (existingLedger.LedgerId == Guid.Empty)
            {
                //  No matching Ledger transaction
                //  Add this import transaction to the Ledger
                _ledgerRepo.Add(ledger);
                createdCount++;
                continue;
            }

            if (existingLedger.IsReconciled)
            {
                //  Existing Ledger Transaction is Reconciled.
                //  TODO: Report import transaction as not taken
                alreadyReconciledCount++;
                continue;
            }

            //  TODO: Update unreconcilled Ledger Transaction and add this Import Transaction
            existingLedger.Reference = ledger.Reference;
            existingLedger.TransactionType = ledger.TransactionType;
            existingLedger.CategoryId = ledger.CategoryId;
            existingLedger.SubcategoryId = ledger.SubcategoryId;
            existingLedger.IsManualEntry = false;

            _ledgerRepo.Update(existingLedger);
            updatedCount++;
        }

        _ledgerRepo.SaveChanges();

        return new ServiceResult<AcceptResult>(
            new AcceptResult
            {
                BankAccountId = bankAccountId,
                TotalAcceptedRowCount = imports.Count,
                TotalCreatedRowCount = createdCount,
                TotalUpdatedRowCount = updatedCount,
                TotalAlreadyReconciledCount = alreadyReconciledCount,
            });
    }

    public ServiceResult<Ledger> AddCredit(Guid bankAccountId, DateTime dateUtc, string description,
        string? reference, string transactionType, double? moneyIn, Guid categoryId, Guid? subcategoryId)
    {
        var ledger = new Ledger
        {
            BankAccountId = bankAccountId,
            DateUtc = dateUtc,
            RowNumber = NextRowNumber(bankAccountId, dateUtc),
            Description = description,
            Reference = reference,
            TransactionType = transactionType,
            MoneyIn = moneyIn,
            MoneyOut = null,
            CategoryId = categoryId,
            SubcategoryId = subcategoryId,
            IsManualEntry= true,
        };

        ledger = _ledgerRepo.Add(ledger);

        _ledgerRepo.SaveChanges();

        return new ServiceResult<Ledger>(payload: ledger);
    }

    public ServiceResult<Ledger> AddDebit(Guid bankAccountId, DateTime dateUtc, string description, string? reference, string transactionType, double? moneyOut, Guid categoryId, Guid? subcategoryId)
    {
        throw new NotImplementedException();
    }

    public ServiceResult<Ledger> AddTransfer(Guid bankAccountId, DateTime dateUtc, string description, string? reference, string transactionType, double? moneyOut, Guid categoryId, Guid? subcategoryId, Guid? transferBankAccountId)
    {
        throw new NotImplementedException();
    }

    private int NextRowNumber(Guid bankAccountId, DateTime dateUtc)
    {
        return _ledgerRepo.NextRowNumber(bankAccountId, dateUtc);
    }
}
