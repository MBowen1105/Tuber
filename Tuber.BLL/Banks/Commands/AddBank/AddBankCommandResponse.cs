using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.AddBank;

public class AddBankCommandResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
}
