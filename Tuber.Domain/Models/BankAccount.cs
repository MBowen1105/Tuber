using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class BankAccount : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public virtual Bank? Bank { get; set; }
}
