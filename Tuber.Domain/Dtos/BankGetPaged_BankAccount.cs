namespace Tuber.Application.Dtos;
public class BankGetPaged_BankAccount
{
    public Guid BankAccountId { get; set; }
    public string? BankAccountName { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKSortCode { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
}
