using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class BankAccount : AuditableEntity
{
    public static readonly string FriendlyName = "Bank Account";

    //TODO: Remove constructor?
    public BankAccount()
    {
        BankAccountId = Guid.Empty;
        BankAccountName = "";
        UKSortCode = "";
        UKBankAccount = "";
        OrderBy = int.MaxValue;
        BankId = Guid.Empty;
        IsDeleted = false;
    }

    public Guid BankAccountId { get; set; }
    public string BankAccountName { get; set; }
    public string UKSortCode { get; set; }
    public string UKBankAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Bank? Bank { get; set; }
}
