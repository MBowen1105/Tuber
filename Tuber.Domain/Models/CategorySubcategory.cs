namespace Tuber.Domain.Models;
public class CategorySubcategory
{
    public static readonly string FriendlyName = "Category/Subcategory";

    public Guid CategorySubcategoryId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public bool IsDeleted { get; set; }
}
