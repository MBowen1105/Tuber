using Tuber.Application.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Ledgers.Queries.LedgerGetPaged;
public class LedgerGetPagedAPIResponse : PagedAPIResponse
{
    public int LedgerCount { get; init; }
    public List<LedgerGetPaged_Ledger> Ledgers { get; init; } = new();
}
