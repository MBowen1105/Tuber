using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.Ledgers.Queries.LedgerGetPaged;
public class LedgerGetPagedQueryRequest : PagedRequest, IRequest<LedgerGetPagedQueryResponse>
{
    public Guid InstitutionAccountId { get; init; }
}
