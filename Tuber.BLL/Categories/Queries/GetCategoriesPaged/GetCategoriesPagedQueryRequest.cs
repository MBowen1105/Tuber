using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Categories.Queries.GetCategoriesPaged;
public class GetCategoriesPagedQueryRequest : PagedRequest, IRequest<GetCategoriesPagedQueryResponse>
{
}
