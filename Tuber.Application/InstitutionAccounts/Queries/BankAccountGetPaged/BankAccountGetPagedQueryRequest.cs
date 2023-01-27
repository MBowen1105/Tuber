using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
public class InstitutionAccountGetPagedQueryRequest : PagedRequest, IRequest<InstitutionAccountGetPagedQueryResponse>
{
}
