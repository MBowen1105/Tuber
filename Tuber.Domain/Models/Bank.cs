using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class Bank : AuditableEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int OrderBy { get; set; }
    public virtual ICollection<BankAccount>? BankAccounts { get; set; }  
}
