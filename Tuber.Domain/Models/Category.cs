using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class Category : AuditableEntity
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = "";
    public bool IsCoreCategory { get; set; }
    public bool IsDeleted { get; set; }
}
