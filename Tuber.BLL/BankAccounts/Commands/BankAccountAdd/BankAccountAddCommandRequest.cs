using MediatR;
using Tuber.BLL.BankAccounts.Commands.AddAccountBank;

namespace Tuber.BLL.BankAccounts.Commands.BankAccountAdd;
public class BankAccountAddCommandRequest : IRequest<BankAccountAddCommandResponse>
{
    public string BankAccountName { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public string UKSortCode { get; set; } = "";
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public int OrderBy { get; init; }
}
