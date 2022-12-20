using Tuber.Core.Common;

namespace Tuber.Application.Banks.Commands.BankUpdate;

public class BankUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
}
