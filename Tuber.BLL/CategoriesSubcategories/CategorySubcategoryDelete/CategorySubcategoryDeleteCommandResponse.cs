using Tuber.Core.Common;

namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryDelete;

public class CategorySubcategoryDeleteCommandResponse : CommandQueryResponseBase
{
	public CategorySubcategoryDeleteCommandResponse()
	{
	}

	public CategorySubcategoryDeleteCommandResponse(int deletedCount, List<Exception> exceptions)
	{
		DeletedCount = deletedCount;
		Exceptions.Clear();
		if (exceptions.Count > 0)
			Exceptions.AddRange(exceptions);
	}

    public int DeletedCount { get; init; }
}
