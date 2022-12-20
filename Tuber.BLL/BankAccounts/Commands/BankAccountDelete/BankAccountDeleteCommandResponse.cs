using Tuber.Core.Common;

namespace Tuber.Application.BankAccounts.Commands.BankAccountDelete;

public class BankAccountDeleteCommandResponse : CommandQueryResponseBase
{
    public BankAccountDeleteCommandResponse(int deletedCount, List<Exception> exceptions)
    {
        DeletedCount = deletedCount;
        Exceptions.Clear();
        if (exceptions.Count > 0)
            Exceptions.AddRange(exceptions);
    }

    public int DeletedCount { get; init; }
}
