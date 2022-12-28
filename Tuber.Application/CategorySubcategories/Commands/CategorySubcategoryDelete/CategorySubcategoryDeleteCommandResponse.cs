using Tuber.Core.Common;

namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryDelete;

public class CategorySubcategoryDeleteCommandResponse : CommandQueryResponseBase
{
	public CategorySubcategoryDeleteCommandResponse()
	{
	}
	public CategorySubcategoryDeleteCommandResponse(Exception exception)
	{
		DeletedCount = 0;
		Exceptions.Add(exception);
	}

    public int DeletedCount { get; init; }
}
