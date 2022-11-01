using Tuber.Core.Common;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.Domains;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryResponse : PagedQueryResponseBase
{
    public PositiveInt? BankCount { get; init; }
    public List<BankDomain> Banks { get; init; } = new List<BankDomain>();
}
