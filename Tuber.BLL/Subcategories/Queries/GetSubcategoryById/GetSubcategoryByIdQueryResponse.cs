using Tuber.Core.Common;

namespace Tuber.BLL.Subcategories.Queries.GetSubcategoryById;
public class GetSubcategoryByIdQueryResponse : CommandQueryResponseBase
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public bool IsCoreSubcategory { get; set; }
}