namespace Tuber.Domain.Dtos;
public class BankAccountDto
{
    public Guid BankAccountId { get; set; }
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKBankAccount { get; set; } = "";
    public string BankName { get; set; } = "";
    public string CreatedByUserFullName { get; set; } = "";
    public DateTime CreatedOnUtc { get; set; }
    public string? UpdatedByUserFullName { get; set; }
    public DateTime UpdatedOnUtc { get; set; }
}
