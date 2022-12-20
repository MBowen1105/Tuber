using MediatR;
using Tuber.Application.Banks.Commands.AddBank;

namespace Tuber.Application.Banks.Commands.BankAdd;
public class BankAddCommandRequest : IRequest<BankAddCommandResponse>
{
    public string BankName { get; set; } = "";
    public int OrderBy { get; set; }
}
