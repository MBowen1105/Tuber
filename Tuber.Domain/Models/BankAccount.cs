using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class BankAccount : AuditableEntity
{
    public BankAccount()
    {
        BankAccountId = Guid.Empty;
        Name = "";
        UKBankAccount = "";
        OrderBy = int.MaxValue;
        BankId = Guid.Empty;
        IsDeleted = true;
    }

    public Guid BankAccountId { get; set; }
    public string Name { get; set; }
    public string UKBankAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
}
