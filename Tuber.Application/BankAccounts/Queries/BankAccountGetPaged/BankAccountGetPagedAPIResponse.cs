using Tuber.Application.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedAPIResponse : PagedAPIResponse
{
    public int BankAccountCount { get; init; }
    public List<BankAccountGetPaged_BankAccount> BankAccounts { get; init; } = new();
}
