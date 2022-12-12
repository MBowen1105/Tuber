using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedAPIResponse : PagedAPIResponse
{
    public int BankAccountCount { get; init; }
    public List<BankAccountGetPaged_BankAccount> BankAccounts { get; init; } = new();
}
