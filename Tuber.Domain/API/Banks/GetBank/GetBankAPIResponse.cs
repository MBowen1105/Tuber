using Tuber.Domain.API.Banks.Domains;

namespace Tuber.Domain.API.Banks.GetBank;
public class GetBankAPIResponse
{
    public int BankCount { get; init; }
    public List<BankDomain> Banks { get; init; } = new List<BankDomain>();
}
