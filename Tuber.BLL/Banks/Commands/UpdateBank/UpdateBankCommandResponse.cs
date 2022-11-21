using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.UpdateBank;

public class UpdateBankCommandResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public string CreatedByUserName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserName { get; init; }
    public DateTime? UpdatedOnUtc { get; init; }
}
