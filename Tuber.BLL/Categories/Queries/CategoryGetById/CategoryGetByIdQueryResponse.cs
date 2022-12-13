using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Queries.CategoryGetById;
public class CategoryGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public bool IsCoreCategory { get; init; } = false;
}