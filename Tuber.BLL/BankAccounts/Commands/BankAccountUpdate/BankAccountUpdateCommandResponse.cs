using Tuber.Core.Common;

namespace Tuber.BLL.BankAccounts.Commands.BankAccountUpdate;

public class BankAccountUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid BankAccountId { get; set; }
    public string BankAccountName { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public string UKSortCode { get; set; } = "";
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public int OrderBy { get; init; }
}
