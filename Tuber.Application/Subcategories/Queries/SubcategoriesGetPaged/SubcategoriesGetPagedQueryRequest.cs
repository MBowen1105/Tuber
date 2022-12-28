using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.Subcategories.Queries.SubcategoriesGetPaged;
public class SubcategoriesGetPagedQueryRequest : PagedRequest, IRequest<SubcategoriesGetPagedQueryResponse>
{
}
