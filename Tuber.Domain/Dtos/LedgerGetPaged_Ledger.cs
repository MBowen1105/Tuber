namespace Tuber.Domain.Dtos;
public class LedgerGetPaged_Ledger
{
    public Guid LedgerId { get; init; }
    public Guid BankAccountId { get; init; }
    public string BankAccountBankAccountName { get; init; } = "";
    public DateTime DateUtc { get; init; }
    public string Description { get; init; } = "";
    public string? Reference { get; init; }
    public string TransactionType { get; init; } = "";
    public double? MoneyIn { get; init; }
    public double? MoneyOut { get; init; }
    public double Balance { get; init; }
    public Guid? CategorySubcategoryId { get; init; }
    public string CategorySubcategoryShortName { get; init; } = "";
    public Guid? TransferBankAccountId { get; init; }
    public bool IsManualEntry { get; init; }
    public bool IsReconciled { get; init; }
    public bool IsDeleted { get; init; }
}
