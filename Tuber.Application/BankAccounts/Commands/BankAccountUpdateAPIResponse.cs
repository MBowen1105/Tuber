namespace Tuber.Application.BankAccounts.Commands.BankAccountUpdate;
public class BankAccountUpdateAPIResponse
{
    public Guid BankAccountId { get; init; }
    public string BankAccountName { get; init; } = "";
    public string? UKSortCode { get; set; }
    public string? UKBankAccountAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
}
