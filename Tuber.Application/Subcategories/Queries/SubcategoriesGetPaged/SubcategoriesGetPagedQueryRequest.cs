using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.Application.Subcategories.Queries.SubcategoriesGetPaged;
public class SubcategoriesGetPagedQueryRequest : PagedRequest, IRequest<SubcategoriesGetPagedQueryResponse>
{
}
