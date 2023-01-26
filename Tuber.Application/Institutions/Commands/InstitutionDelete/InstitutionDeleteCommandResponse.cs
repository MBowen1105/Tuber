using Tuber.Core.Common;

namespace Tuber.Application.Institutions.Commands.InstitutionDelete;

public class InstitutionDeleteCommandResponse : CommandQueryResponseBase
{
	public InstitutionDeleteCommandResponse()
	{
	}

	public InstitutionDeleteCommandResponse(Exception exception)
	{
		DeletedCount = 0;
		Exceptions.Add(exception);
	}

    public int DeletedCount { get; init; }
}
