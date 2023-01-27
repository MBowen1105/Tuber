using Tuber.Application.Common;
using Tuber.Domain.Enums;

namespace Tuber.Domain.Models;
public class Ledger : AuditableEntity
{
    public static readonly string FriendlyName = "Ledger";

    //public Ledger()
    //{
    //    LedgerId = Guid.Empty;
    //    InstitutionAccountId = Guid.Empty;
    //    DateUtc = DateTime.MinValue;
    //    RowNumber = 0;
    //    Description = string.Empty;
    //    Reference = string.Empty;
    //    TransactionType = string.Empty;
    //    MoneyIn = 0;
    //    MoneyOut = 0;
    //    Balance = 0;
    //    CategoryId = Guid.Empty;
    //    SubcategoryId = null;
    //    TransferInstitutionAccountId = null;
    //    TransactionOrigin = TransactionOrigin.Unknown;
    //    IsReconciled = false;
    //    IsDeleted = false;
    //}

    public Guid LedgerId { get; init; }
    public Guid InstitutionAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public int RowNumber { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Reference { get; set; }
    public string TransactionType { get; set; } = string.Empty;
    public double? MoneyIn { get; set; }
    public double? MoneyOut { get; set; }
    public double Balance { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public Guid? TransferInstitutionAccountId { get; set; }
    public TransactionOrigin TransactionOrigin { get; set; }
    public bool IsReconciled { get; init; }
    public bool IsDeleted { get; set; }
    public virtual InstitutionAccount? InstitutionAccount { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Subcategory? Subcategory { get; set; }
}
