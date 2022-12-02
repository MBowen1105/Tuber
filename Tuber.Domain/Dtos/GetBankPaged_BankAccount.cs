namespace Tuber.Domain.Dtos;
public class GetBankPaged_BankAccount
{
    public Guid BankAccountId { get; set; }
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKSortCode { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
}
