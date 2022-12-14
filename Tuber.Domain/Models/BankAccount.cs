using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class BankAccount : AuditableEntity
{
    public static readonly string FriendlyName = "Bank Account";

    public BankAccount()
    {
        BankAccountId = Guid.Empty;
        Name = "";
        UKSortCode = "";
        UKBankAccount = "";
        OrderBy = int.MaxValue;
        BankId = Guid.Empty;
        IsDeleted = false;
    }

    public Guid BankAccountId { get; set; }
    public string Name { get; set; }
    public string UKSortCode { get; set; }
    public string UKBankAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
}
