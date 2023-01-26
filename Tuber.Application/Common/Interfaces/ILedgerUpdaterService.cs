using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ILedgerUpdaterService
{
    ServiceResult<AcceptResult> Accept(Guid bankAccountId, List<Import> imports);
    ServiceResult<Ledger> AddCredit(Guid bankAccountId, DateTime dateUtc, string description, string? reference,
        string transactionType, double moneyIn, Guid categoryId, Guid? subcategoryId);
    ServiceResult<Ledger> AddDebit(Guid bankAccountId, DateTime dateUtc, string description, string? reference,
        string transactionType, double moneyOut, Guid categoryId, Guid? subcategoryId);
    ServiceResult<Ledger> AddTransferOut(Guid bankAccountId, DateTime dateUtc, string description, 
        string? reference, double moneyOut, Guid categoryId, Guid? subcategoryId, Guid transferInstitutionAccountId);
}
