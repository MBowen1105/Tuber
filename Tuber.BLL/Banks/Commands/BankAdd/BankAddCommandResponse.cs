using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.AddBank;

public class BankAddCommandResponse : CommandQueryResponseBase
{
    public Guid BankId { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
}
