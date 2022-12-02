using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public class GetBankPaged_Bank
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; } = 0;
    public List<GetBankPaged_BankAccount> BankAccounts { get; set; } = new();
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; }
    public DateTime UpdatedOnUtc { get; init; }
}
