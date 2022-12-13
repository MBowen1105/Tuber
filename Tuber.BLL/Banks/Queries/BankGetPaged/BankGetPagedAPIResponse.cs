using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.BankGetPaged;
public class BankGetPagedAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<BankGetPaged_Bank> Banks { get; init; } = new();
}
