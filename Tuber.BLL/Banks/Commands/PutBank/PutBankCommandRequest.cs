using MediatR;

namespace Tuber.BLL.Banks.Commands.PutBank;
public class PutBankCommandRequest : IRequest<PutBankCommandResponse>
{
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
}
