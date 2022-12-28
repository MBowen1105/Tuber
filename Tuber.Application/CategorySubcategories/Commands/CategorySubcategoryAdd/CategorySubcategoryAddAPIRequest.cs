namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddAPIRequest
{
    public Guid CategoryId { get; init; }
    public Guid? SubcategoryId { get; init; }
}
