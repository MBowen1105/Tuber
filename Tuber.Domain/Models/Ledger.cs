using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Ledger : AuditableEntity
{
    public static readonly string FriendlyName = "Ledger";

    public Ledger()
    {
        LedgerId = Guid.Empty;
        BankAccountId = Guid.Empty;
        DateUtc = DateTime.MinValue;
        RowNumber = 0;
        Description = string.Empty;
        Reference = string.Empty;
        TransactionType = string.Empty;
        MoneyIn = 0;
        MoneyOut = 0;
        Balance = 0;
        CategoryId = Guid.Empty;
        SubcategoryId = null;
        TransferBankAccountId = null;
        IsManualEntry = false;
        IsReconciled = false;
        IsDeleted = false;
    }

    public Guid LedgerId { get; init; }
    public Guid BankAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public int RowNumber { get; set; }
    public string Description { get; set; }
    public string? Reference { get; set; }
    public string TransactionType { get; set; }
    public double? MoneyIn { get; set; }
    public double? MoneyOut { get; set; }
    public double Balance { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public Guid? TransferBankAccountId { get; set; }
    public bool IsManualEntry { get; set; }
    public bool IsReconciled { get; init; }
    public bool IsDeleted { get; set; }
    public virtual BankAccount? BankAccount { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Subcategory? Subcategory { get; set; }
}
