using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class Bank : AuditableEntity
{
    public Guid BankId { get; set; }
    public string? Name { get; set; }
    public int OrderBy { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<BankAccount>? BankAccounts { get; set; }  
}
