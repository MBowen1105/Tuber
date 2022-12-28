using Tuber.Application.API.Common;
using Tuber.Application.Dtos;

namespace Tuber.Application.Banks.Queries.BankGetPaged;
public class BankGetPagedAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<BankGetPaged_Bank> Banks { get; init; } = new();
}
