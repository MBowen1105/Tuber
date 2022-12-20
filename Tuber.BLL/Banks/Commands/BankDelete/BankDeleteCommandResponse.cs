using Tuber.Core.Common;

namespace Tuber.Application.Banks.Commands.BankDelete;

public class BankDeleteCommandResponse : CommandQueryResponseBase
{
	public BankDeleteCommandResponse()
	{
	}
	public BankDeleteCommandResponse(int deletedCount, List<Exception> exceptions)
	{
		DeletedCount = deletedCount;
		Exceptions.Clear();
		if (exceptions.Count > 0)
			Exceptions.AddRange(exceptions);
	}

    public int DeletedCount { get; init; }
}
