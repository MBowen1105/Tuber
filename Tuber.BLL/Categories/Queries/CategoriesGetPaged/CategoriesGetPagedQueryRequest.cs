using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Categories.Queries.CategoriesGetPaged;
public class CategoriesGetPagedQueryRequest : PagedRequest, IRequest<CategoriesGetPagedQueryResponse>
{
}
