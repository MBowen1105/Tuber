using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
public class GetBankAccountPagedAPIResponse : PagedAPIResponse
{
    public int BankAccountCount { get; init; }
    public List<BankAccountDto> BankAccounts { get; init; } = new();
}
