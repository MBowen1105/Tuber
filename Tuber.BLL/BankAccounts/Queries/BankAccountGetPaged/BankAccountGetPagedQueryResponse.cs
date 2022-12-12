using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedQueryResponse : PagedQueryResponseBase
{
    public int BankAccountCount { get; init; } = 0;
    public List<BankAccountGetPaged_BankAccount> BankAccounts { get; init; } = new();
}
