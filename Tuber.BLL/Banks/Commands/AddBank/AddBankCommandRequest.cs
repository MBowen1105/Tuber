using MediatR;

namespace Tuber.BLL.Banks.Commands.AddBank;
public class AddBankCommandRequest : IRequest<AddBankCommandResponse>
{
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
}
