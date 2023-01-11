using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Bank : AuditableEntity
{
    public static readonly string FriendlyName = "Bank";

    public Bank()
    {
        BankId = Guid.Empty;
        BankName = "";
        OrderBy = int.MaxValue;
        BankAccounts = new List<BankAccount>();
        ImportTemplateId = null;
        ImportTemplate = null;
        IsDeleted = false;       
    }

    public Guid BankId { get; set; }
    public string BankName { get; set; }
    public int OrderBy { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<BankAccount>? BankAccounts { get; set; }
    public ImportTemplate? ImportTemplate { get; init; }
}
