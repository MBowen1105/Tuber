using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Institution : AuditableEntity
{
    public static readonly string FriendlyName = "Institution";

    public Guid InstitutionId { get; init; } = Guid.Empty;
    public string InstitutionName { get; set; } = string.Empty;
    public int OrderBy { get; set; } = int.MaxValue;
    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<InstitutionAccount> InstitutionAccounts { get; init; } = new List<InstitutionAccount>();
}
