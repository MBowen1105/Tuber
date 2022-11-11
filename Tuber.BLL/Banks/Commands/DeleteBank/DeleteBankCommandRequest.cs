using MediatR;

namespace Tuber.BLL.Banks.Commands.DeleteBank;
public class DeleteBankCommandRequest : IRequest<DeleteBankCommandResponse>
{
    public Guid Id { get; set; }
}
