using MediatR;

namespace Tuber.BLL.Banks.Commands;
public class PutBankCommandRequest : IRequest<PutBankCommandResponse>
{
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
}
