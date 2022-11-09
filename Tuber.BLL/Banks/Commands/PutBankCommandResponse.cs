using Tuber.BLL.Common;

namespace Tuber.BLL.Banks.Commands;

public class PutBankCommandResponse : QueryResponseBase
{
    public Guid Id { get; init; }
}
