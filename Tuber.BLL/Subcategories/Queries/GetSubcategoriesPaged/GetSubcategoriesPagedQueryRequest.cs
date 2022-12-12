using MediatR;
using Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
public class GetSubcategoriesPagedQueryRequest : PagedRequest, IRequest<GetSubcategoriesPagedQueryResponse>
{
}
