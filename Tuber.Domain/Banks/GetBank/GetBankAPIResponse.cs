using Tuber.Domain.Banks.Models;
using Tuber.Domain.API.Common;

namespace Tuber.Domain.Banks.GetBank;
public class GetBankAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<BankDto> Banks { get; init; } = new List<BankDto>();
}
