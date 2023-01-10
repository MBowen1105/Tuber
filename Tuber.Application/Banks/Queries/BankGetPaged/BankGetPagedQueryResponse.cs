using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Banks.Queries.BankGetPaged;
public class BankGetPagedQueryResponse : PagedQueryResponseBase
{
    public int BankCount { get; init; } = 0;
    public List<BankGetPaged_Bank> Banks { get; init; } = new();
}
