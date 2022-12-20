using Tuber.Core.Common;

namespace Tuber.Application.Subcategories.Queries.SubcategoryGetById;
public class SubcategoryGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public bool IsCoreSubcategory { get; set; }
}