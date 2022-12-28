using Tuber.Application.Common;

namespace Tuber.Application.Models;
public class Bank : AuditableEntity
{
    public static readonly string FriendlyName = "Bank";

    public Bank()
    {
        BankId = Guid.Empty;
        BankName = "";
        OrderBy = int.MaxValue;
        ImportTemplateId = null;
        IsDeleted = false;       
        BankAccounts = new List<BankAccount>();
        ImportTemplate = null;
    }

    public Guid BankId { get; set; }
    public string BankName { get; set; }
    public int OrderBy { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<BankAccount>? BankAccounts { get; set; }
    public virtual ImportTemplate? ImportTemplate { get; init; }
}
