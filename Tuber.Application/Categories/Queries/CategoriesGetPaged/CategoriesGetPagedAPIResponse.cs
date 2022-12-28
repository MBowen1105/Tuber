using Tuber.Application.API.Common;
using Tuber.Application.Dtos;

namespace Tuber.Application.Categories.Queries.CategoriesGetPaged;
public class CategoriesGetPagedAPIResponse : PagedAPIResponse
{
    public int CategoryCount { get; init; }
    public List<GetCategoriesPaged_Category> Categories { get; init; } = new();
}
