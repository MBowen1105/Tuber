using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.Institutions.Queries.InstitutionGetPaged;
public class InstitutionGetPagedQueryRequest : PagedRequest, IRequest<InstitutionGetPagedQueryResponse>
{
}
