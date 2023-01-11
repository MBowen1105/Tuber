using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Category : AuditableEntity
{
    public static readonly string FriendlyName = "Category";
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = "";
    public bool IsCoreCategory { get; set; }
    public bool IsDeleted { get; set; }
}
