using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Subcategories.Queries.SubcategoriesGetPaged;
public class SubcategoriesGetPagedQueryRequest : PagedRequest, IRequest<SubcategoriesGetPagedQueryResponse>
{
}
