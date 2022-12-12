namespace Tuber.BLL.Subcategories.Queries.GetSubcategoryById;
public class GetSubcategoryByIdAPIResponse
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public bool IsCoreSubcategory { get; init; }
}
