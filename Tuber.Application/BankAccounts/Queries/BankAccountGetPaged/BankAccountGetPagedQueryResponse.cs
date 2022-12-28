using Tuber.Core.Common;
using Tuber.Application.Dtos;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedQueryResponse : PagedQueryResponseBase
{
    public int BankAccountCount { get; init; } = 0;
    public List<BankAccountGetPaged_BankAccount> BankAccounts { get; init; } = new();
}
