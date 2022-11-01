using Tuber.Domain.API.Banks.Domains;
using Tuber.Domain.API.Common;

namespace Tuber.Domain.API.Banks.GetBank;
public class GetBankAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<BankDomain> Banks { get; init; } = new List<BankDomain>();
}
