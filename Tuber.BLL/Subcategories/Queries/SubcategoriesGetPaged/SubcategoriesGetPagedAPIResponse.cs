using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Subcategories.Queries.SubcategoriesGetPaged;
public class SubcategoriesGetPagedAPIResponse : PagedAPIResponse
{
    public int SubcategoryCount { get; init; }
    public List<GetSubcategoriesPaged_Subcategory> Subcategories { get; init; } = new();
}
