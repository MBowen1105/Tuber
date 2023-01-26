using Tuber.Application.API.Common;

namespace Tuber.Application.Ledgers.Queries.LedgerGetPaged;
public class LedgerGetPagedAPIRequest : PagedAPIRequest
{
    public Guid InstitutionAccountId { get; init; }
}
