using MediatR;

namespace Tuber.BLL.Banks.Commands.BankDelete;
public class BankDeleteCommandRequest : IRequest<BankDeleteCommandResponse>
{
    public Guid Id { get; set; }
}
