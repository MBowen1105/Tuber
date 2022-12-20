namespace Tuber.Application.Categorys.Queries.CategoryGetById;
public class CategoryGetByIdAPIResponse
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public bool IsCoreCategory { get; init; } = false;
}
