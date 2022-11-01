using Tuber.Core.Common;
using Tuber.Domain.API.Banks.Models;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryResponse : PagedQueryResponseBase
{
    public int BankCount { get; init; } = 0;
    public List<BankDto> Banks { get; init; } = new List<BankDto>();
}
