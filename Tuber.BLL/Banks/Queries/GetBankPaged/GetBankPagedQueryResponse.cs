using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.GetBankPaged;
public class GetBankPagedQueryResponse : PagedQueryResponseBase
{
    public int BankCount { get; init; } = 0;
    public List<GetBankPaged_Bank> Banks { get; init; } = new();
}
