namespace Tuber.BLL.Subcategories.Queries.SubcategoryGetById;
public class SubcategoryGetByIdAPIResponse
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public bool IsCoreSubcategory { get; init; }
}
