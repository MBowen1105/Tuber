using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Bank : AuditableEntity
{
    public static readonly string FriendlyName = "Bank";

    public Guid BankId { get; init; } = Guid.Empty;
    public string BankName { get; set; } = string.Empty;
    public int OrderBy { get; set; } = int.MaxValue;
    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<BankAccount> BankAccounts { get; init; } = new List<BankAccount>();
}
