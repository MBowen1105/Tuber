using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.UpdateBank;

public class UpdateBankCommandResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
    public Guid? UpdatedByUserId { get; init; }
    public DateTime? UpdatedOn { get; init; }
}
