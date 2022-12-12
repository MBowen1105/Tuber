using MediatR;
using Tuber.BLL.Banks.Commands.AddBank;

namespace Tuber.BLL.Banks.Commands.BankAdd;
public class BankAddCommandRequest : IRequest<BankAddCommandResponse>
{
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
}
