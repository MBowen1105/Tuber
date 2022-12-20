using MediatR;

namespace Tuber.Application.Banks.Commands.BankDelete;
public class BankDeleteCommandRequest : IRequest<BankDeleteCommandResponse>
{
    public Guid BankId { get; set; }
}
