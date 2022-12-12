using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.BankDelete;

public class BankDeleteCommandResponse : CommandQueryResponseBase
{
    public int DeletedCount { get; init; }
}
