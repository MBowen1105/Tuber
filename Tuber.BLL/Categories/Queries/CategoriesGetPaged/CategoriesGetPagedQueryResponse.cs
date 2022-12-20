using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Categories.Queries.CategoriesGetPaged;
public class CategoriesGetPagedQueryResponse : PagedQueryResponseBase
{
    public int CategoryCount { get; init; } = 0;
    public List<GetCategoriesPaged_Category> Categories { get; init; } = new();
}
