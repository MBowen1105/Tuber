using Tuber.Domain.API.Banks.Domains;

namespace Tuber.Domain.API.Banks.GetBank;
public class GetBankAPIResponse
{
    public int BankCount { get; init; }
    public BankDomain[] Bank { get; init; } = Array.Empty<BankDomain>();
}
