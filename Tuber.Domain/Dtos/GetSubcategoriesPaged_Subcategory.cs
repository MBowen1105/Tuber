namespace Tuber.Application.Dtos;
public class GetSubcategoriesPaged_Subcategory
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public bool IsCoreSubcategory { get; init; } = false;
    
}
