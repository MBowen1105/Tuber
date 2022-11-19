using MediatR;

namespace Tuber.BLL.Banks.Commands.UpdateBank;
public class UpdateBankCommandRequest : IRequest<UpdateBankCommandResponse>
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public int OrderBy { get; init; }
}
