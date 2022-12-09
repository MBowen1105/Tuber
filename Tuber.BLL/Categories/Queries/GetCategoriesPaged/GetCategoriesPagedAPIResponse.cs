using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Categories.Queries.GetCategoriesPaged;
public class GetCategoriesPagedAPIResponse : PagedAPIResponse
{
    public int CategoryCount { get; init; }
    public List<GetCategoriesPaged_Category> Categories { get; init; } = new();
}
