using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Subcategories.Queries.SubcategoriesGetPaged;
public class SubcategoriesGetPagedQueryResponse : PagedQueryResponseBase
{
    public int SubcategoryCount { get; init; } = 0;
    public List<GetSubcategoriesPaged_Subcategory> Subcategories { get; init; } = new();
}
