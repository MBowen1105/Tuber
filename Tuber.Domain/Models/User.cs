using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class User : AuditableEntity
{
    public Guid UserId { get; set; }
    public string FullName { get; set; } = "";
    public bool IsCoreUser { get; set; }
    public bool IsActive { get; set; }
}
