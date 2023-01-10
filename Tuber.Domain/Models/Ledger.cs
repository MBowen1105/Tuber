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
        Description = string.Empty;
        Reference = string.Empty;
        TransactionType = string.Empty;
        MoneyIn = 0;
        MoneyOut = 0;
        Balance = 0;
        CategorySubcategoryId = null;
        //BankAccount = new BankAccount();
        //CategorySubcategory = new CategorySubcategory();
    }

    public Guid LedgerId { get; init; }
    public Guid BankAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public string Description { get; set; }
    public string? Reference { get; set; }
    public string TransactionType { get; set; }
    public double? MoneyIn { get; set; }
    public double? MoneyOut { get; set; }
    public double Balance { get; set; }
    public Guid? CategorySubcategoryId { get; set; }
    public bool IsManualEntry { get; set; }
    public bool IsReconciled { get; init; }
    public bool IsDeleted { get; set; }
    //public virtual BankAccount BankAccount { get; set; }
    //public virtual CategorySubcategory CategorySubcategory { get; set; }
}
