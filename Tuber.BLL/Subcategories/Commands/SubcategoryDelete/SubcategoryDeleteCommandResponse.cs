using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.CategoryDelete;

public class CategoryDeleteCommandResponse : CommandQueryResponseBase
{
    public int DeletedCount { get; init; }
}
