using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class Subcategory : AuditableEntity
{
    public static readonly string FriendlyName = "Subcategory";
    public Guid SubcategoryId { get; set; }
    public string SubcategoryName { get; set; } = "";
    public bool IsCoreSubcategory { get; set; }
    public bool IsDeleted { get; set; }
}
