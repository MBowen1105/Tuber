using Tuber.BLL.Common;

namespace Tuber.BLL.Banks.Commands.PutBank;

public class PutBankCommandResponse : QueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
    public Guid UpdatedByUserId { get; init; }
    public DateTime UpdatedOn { get; init; }
}
