using Tuber.Core.Common;

namespace Tuber.Application.Subcategories.Commands.SubcategoryDelete;

public class SubcategoryDeleteCommandResponse : CommandQueryResponseBase
{
    public SubcategoryDeleteCommandResponse()
    {
    }

    public SubcategoryDeleteCommandResponse(Exception exception)
    {
        DeletedCount = 0;
        Exceptions.Clear();
        Exceptions.Add(exception);
    }

    public SubcategoryDeleteCommandResponse(int deletedCount, List<Exception> exceptions)
    {
        DeletedCount = deletedCount;
        Exceptions.Clear();
        if (exceptions.Count > 0)
            Exceptions.AddRange(exceptions);
    }

    public int DeletedCount { get; init; }
}
