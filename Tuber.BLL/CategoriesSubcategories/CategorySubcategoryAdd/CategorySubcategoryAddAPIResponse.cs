namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddAPIResponse
{
    public Guid CategorySubcategoryId { get; init; }
    public Guid CategoryId { get; init; }
    public Guid? SubcategoryId { get; init; }
}
