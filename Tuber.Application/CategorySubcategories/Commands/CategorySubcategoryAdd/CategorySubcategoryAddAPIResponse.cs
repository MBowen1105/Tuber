namespace Tuber.Application.CategorySubcategories.Commands.InstitutionAdd;
public class CategorySubcategoryAddAPIResponse
{
    public Guid CategorySubcategoryId { get; init; }
    public Guid CategoryId { get; init; }
    public Guid? SubcategoryId { get; init; }
}
