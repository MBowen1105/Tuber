namespace Tuber.Application.BankAccounts.Commands.BankAccountUpdate;
public class BankAccountUpdateAPIResponse
{
    public Guid BankAccountId { get; set; }
    public string BankAccountName { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public string UKSortCode { get; set; } = "";
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public int OrderBy { get; init; }
}
