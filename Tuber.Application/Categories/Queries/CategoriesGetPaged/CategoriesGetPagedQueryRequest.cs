using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.Categories.Queries.CategoriesGetPaged;
public class CategoriesGetPagedQueryRequest : PagedRequest, IRequest<CategoriesGetPagedQueryResponse>
{
}
