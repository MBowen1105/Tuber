using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Domain.Banks.GetBank;
public class GetBankPagedAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<BankDto> Banks { get; init; } = new List<BankDto>();
}
