using MediatR;

namespace Tuber.Application.Banks.Commands.BankUpdate;
public class BankUpdateCommandRequest : IRequest<BankUpdateCommandResponse>
{
    public Guid BankId { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
}
