using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.BankUpdate;

public class BankUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
}
