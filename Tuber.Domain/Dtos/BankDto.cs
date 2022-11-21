using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public record BankDto
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; } = 0;
    public List<BankAccount> BankAccounts { get; set; } = new();
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; }
    public DateTime UpdatedOnUtc { get; init; }
    public bool IsActive { get; init; }

}
