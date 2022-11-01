using Tuber.Core.Common;
using Tuber.Domain.API.Banks.Domains;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryResponse : PagedQueryResponseBase
{
    public int BankCount { get; init; } = 0;
    public List<BankDomain> Banks { get; init; } = new List<BankDomain>();
}
