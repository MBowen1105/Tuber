namespace Tuber.BLL.Subcategories.Commands.SubcategoryUpdate;
public class SubcategoryUpdateAPIRequest
{
    public Guid SubcategoryId { get; set; }
    public string SubcategoryName { get; set; } = "";
}
