using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Categories.Queries.GetCategoriesPaged;
public class GetCategoriesPagedQueryResponse : PagedQueryResponseBase
{
    public int CategoryCount { get; init; } = 0;
    public List<GetCategoriesPaged_Category> Categories { get; init; } = new();
}
