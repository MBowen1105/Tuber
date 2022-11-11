using Tuber.BLL.Common;

namespace Tuber.BLL.Banks.Commands;

public class PutBankCommandResponse : QueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UpdatedByUserId { get; set; }
    public DateTime UpdatedOn { get; set; }
}
