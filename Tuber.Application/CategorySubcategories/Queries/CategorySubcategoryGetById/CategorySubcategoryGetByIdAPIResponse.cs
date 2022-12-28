namespace Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;
public class CategorySubcategoryGetByIdAPIResponse
{
    public Guid CategorySubcategoryId { get; init; }
    public bool IsCoreCategorySubcategory { get; init; }
    public string ShortName { get; init; } = "";
   
}
