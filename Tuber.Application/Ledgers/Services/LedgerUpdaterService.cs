using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Services;
public class LedgerUpdaterService : ILedgerUpdaterService
{
    private readonly ILedgerRepository _ledgerRepo;

    public LedgerUpdaterService(ILedgerRepository ledgerRepo)
    {
        _ledgerRepo = ledgerRepo;
    }

    public ServiceResult<AcceptResult> Accept(Guid bankAccountId, List<Import> imports)
    {
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
                Description = import.DescriptionValue!,
                Reference = import.ReferenceOnStatementValue!,
                TransactionType = import.TransactionTypeValue!,
                MoneyIn = moneyIn,
                MoneyOut = moneyOut,
                Balance = double.Parse(import.BalanceOnStatementValue!),
                CategorySubcategoryId = import.SuggestedCategorySubcategoryId
            };

            _ledgerRepo.Add(ledger);
        }

        _ledgerRepo.SaveChanges();

        return new ServiceResult<AcceptResult>(
            new AcceptResult
            {
                BankAccountId = bankAccountId,
                TotalAcceptedRowCount = imports.Count,
            });
    }
}
