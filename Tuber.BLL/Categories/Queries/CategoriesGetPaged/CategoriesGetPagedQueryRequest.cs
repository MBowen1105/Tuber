using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.Application.Categories.Queries.CategoriesGetPaged;
public class CategoriesGetPagedQueryRequest : PagedRequest, IRequest<CategoriesGetPagedQueryResponse>
{
}
