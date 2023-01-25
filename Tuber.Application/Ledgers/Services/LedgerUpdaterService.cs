using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Common;
using Tuber.Domain.Enums;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Services;
public class LedgerUpdaterService : ILedgerUpdaterService
{
    private readonly ILedgerRepository _ledgerRepo;
    private readonly IBankAccountRepository _bankAccountRepo;

    public LedgerUpdaterService(
        ILedgerRepository ledgerRepo,
        IBankAccountRepository bankAccountRepo)
    {
        _ledgerRepo = ledgerRepo;
        _bankAccountRepo = bankAccountRepo;
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
            existingLedger.TransactionOrigin = TransactionOrigin.Imported;

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
        string? reference, string transactionType, double moneyIn, Guid categoryId, Guid? subcategoryId)
    {
        double balanceBF = GetBalancePriorTo(bankAccountId, dateUtc);

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
            Balance = balanceBF + moneyIn,
            CategoryId = categoryId,
            SubcategoryId = subcategoryId,
            TransactionOrigin = TransactionOrigin.Manual,
        };

        ledger = _ledgerRepo.Add(ledger);

        RecalculateBalances(bankAccountId, dateUtc, balanceBF);

        _ledgerRepo.SaveChanges();

        return new ServiceResult<Ledger>(payload: ledger);
    }

    public ServiceResult<Ledger> AddDebit(Guid bankAccountId, DateTime dateUtc, string description,
        string? reference, string transactionType, double moneyOut, Guid categoryId, Guid? subcategoryId)
    {
        double balanceBF = GetBalancePriorTo(bankAccountId, dateUtc);

        var ledger = new Ledger
        {
            BankAccountId = bankAccountId,
            DateUtc = dateUtc,
            RowNumber = NextRowNumber(bankAccountId, dateUtc),
            Description = description,
            Reference = reference,
            TransactionType = transactionType,
            MoneyIn = null,
            MoneyOut = moneyOut,
            Balance = balanceBF - moneyOut,
            CategoryId = categoryId,
            SubcategoryId = subcategoryId,
            TransactionOrigin = TransactionOrigin.Manual,
        };

        ledger = _ledgerRepo.Add(ledger);

        RecalculateBalances(bankAccountId, dateUtc, balanceBF);

        _ledgerRepo.SaveChanges();

        return new ServiceResult<Ledger>(payload: ledger);
    }

    public ServiceResult<Ledger> AddTransferOut(Guid bankAccountId, DateTime dateUtc, string description, 
        string? reference, double moneyOut, Guid categoryId, Guid? subcategoryId,
        Guid transferBankAccountId)
    {
        double balanceBF = GetBalancePriorTo(bankAccountId, dateUtc);

        var ledger = new Ledger
        {
            BankAccountId = bankAccountId,
            DateUtc = dateUtc,
            RowNumber = NextRowNumber(bankAccountId, dateUtc),
            Description = description,
            Reference = reference,
            TransactionType = "TRANOUT",
            MoneyIn = null,
            MoneyOut = moneyOut,
            Balance = balanceBF - moneyOut,
            TransferBankAccountId = transferBankAccountId,
            CategoryId = categoryId,
            SubcategoryId = subcategoryId,
            TransactionOrigin = TransactionOrigin.Manual,
        };

        ledger = _ledgerRepo.Add(ledger);

        RecalculateBalances(bankAccountId, dateUtc, balanceBF);

        //  Add the balancing transaction
        balanceBF = GetBalancePriorTo(transferBankAccountId, dateUtc);

        var balancingLedger = new Ledger
        {
            BankAccountId = transferBankAccountId,
            DateUtc = dateUtc,
            RowNumber = NextRowNumber(transferBankAccountId, dateUtc),
            Description = description,
            Reference = reference,
            TransactionType = "TRANIN",
            MoneyIn = moneyOut,
            MoneyOut = null,
            Balance = balanceBF + moneyOut,
            TransferBankAccountId = bankAccountId,
            CategoryId = categoryId,
            SubcategoryId = subcategoryId,
            TransactionOrigin = TransactionOrigin.Manual,
        };

        _ledgerRepo.Add(balancingLedger);

        RecalculateBalances(transferBankAccountId, dateUtc, balanceBF);

        _ledgerRepo.SaveChanges();

        return new ServiceResult<Ledger>(payload: ledger);
    }

    private int NextRowNumber(Guid bankAccountId, DateTime dateUtc)
    {
        return _ledgerRepo.NextRowNumber(bankAccountId, dateUtc);
    }

    private double GetBalancePriorTo(Guid bankAccountId, DateTime dateUtc)
    {
        //  Get the balance of the transaction immediately prior to this one or null if there are none.
        var balanceBF = _ledgerRepo.GetBalancePriorTo(bankAccountId, dateUtc);

        //  If there is no transaction prior to this one, take the opening balance of the account
        if (balanceBF is not null)
            return (double)balanceBF;

        var bankAccount = _bankAccountRepo.GetById(bankAccountId);
        return bankAccount.OpeningBalance;
    }

    private void RecalculateBalances(Guid bankAccountId, DateTime dateUtc, double balanceBF)
    {
        //  Read all ledger transactions on or after this one
        var ledgerTransactionsList = _ledgerRepo.GetBetweenDates(bankAccountId, dateUtc, DateTime.MaxValue);

        //  Recalculate the balances
        var runningBalance = balanceBF;
        foreach (var lt in ledgerTransactionsList)
        {
            double amountIn = lt.MoneyIn ?? 0;
            double amountOut = lt.MoneyOut?? 0;
            
            runningBalance = runningBalance + amountIn! - amountOut!;

            lt.Balance = runningBalance;

            //  TODO: New Repo method to update a list of domains
            _ledgerRepo.Update(lt);
        }
    }
}
