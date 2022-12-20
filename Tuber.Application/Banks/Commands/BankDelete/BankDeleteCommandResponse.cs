using Tuber.Core.Common;

namespace Tuber.Application.Banks.Commands.BankDelete;

public class BankDeleteCommandResponse : CommandQueryResponseBase
{
	public BankDeleteCommandResponse()
	{
	}
	public BankDeleteCommandResponse(Exception exception)
	{
		DeletedCount = 0;
		Exceptions.Add(exception);
	}

    public int DeletedCount { get; init; }
}
