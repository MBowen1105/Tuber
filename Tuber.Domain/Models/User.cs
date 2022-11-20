using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class User : AuditableEntity
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
}
