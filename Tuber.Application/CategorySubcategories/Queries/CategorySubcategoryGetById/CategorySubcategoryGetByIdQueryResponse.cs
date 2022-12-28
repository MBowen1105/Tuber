using Tuber.Core.Common;

namespace Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;
public class CategorySubcategoryGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid CategorySubcategoryId { get; init; }
    public string ShortName { get; init; } = "";
}