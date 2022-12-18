using MediatR;

namespace Tuber.BLL.BankAccounts.Commands.BankAccountDelete;
public class BankAccountDeleteCommandRequest : IRequest<BankAccountDeleteCommandResponse>
{
    public Guid BankAccountId { get; set; }
}
