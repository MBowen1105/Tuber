namespace Tuber.Domain.Dtos;
public class BankAccountGetPaged_BankAccount
{
    public Guid BankAccountId { get; set; }
    public string? BankAccountName { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKSortCode { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public string CreatedByUserFullName { get; set; } = "";
    public DateTime CreatedOnUtc { get; set; }
    public string? UpdatedByUserFullName { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}
