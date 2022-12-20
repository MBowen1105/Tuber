using MediatR;

namespace Tuber.Application.BankAccounts.Commands.BankAccountDelete;
public class BankAccountDeleteCommandRequest : IRequest<BankAccountDeleteCommandResponse>
{
    public Guid BankAccountId { get; set; }
}
