using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Domain.Banks.GetBank;
public class GetBankAccountPagedAPIResponse : PagedAPIResponse
{
    public int BankAccountCount { get; init; }
    public List<BankAccountDto> BankAccounts { get; init; } = new List<BankAccountDto>();
}
