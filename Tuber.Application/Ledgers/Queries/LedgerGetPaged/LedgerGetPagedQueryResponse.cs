using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Ledgers.Queries.LedgerGetPaged;
public class LedgerGetPagedQueryResponse : PagedQueryResponseBase
{
    public int LedgerCount { get; init; } = 0;
    public List<LedgerGetPaged_Ledger> Ledgers { get; init; } = new();
}
