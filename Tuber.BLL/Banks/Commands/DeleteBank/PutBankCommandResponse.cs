using Tuber.Core.Common;

namespace Tuber.BLL.Banks.Commands.DeleteBank;

public class DeleteBankCommandResponse : CommandQueryResponseBase
{
    public int DeletedCount { get; init; }
}
