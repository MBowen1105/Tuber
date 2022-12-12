using MediatR;

namespace Tuber.BLL.Banks.Commands.BankUpdate;
public class BankUpdateCommandRequest : IRequest<BankUpdateCommandResponse>
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
}
