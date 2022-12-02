using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class Bank : AuditableEntity
{
    public Bank()
    {
        BankId = Guid.Empty;
        Name = "";
        OrderBy = int.MaxValue;
        ImportTemplateId = null;
        IsDeleted = false;       
        BankAccounts = new List<BankAccount>();
        ImportTemplate = null;
    }

    public Guid BankId { get; set; }
    public string Name { get; set; }
    public int OrderBy { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<BankAccount>? BankAccounts { get; set; }
    public virtual ImportTemplate? ImportTemplate { get; init; }
}
