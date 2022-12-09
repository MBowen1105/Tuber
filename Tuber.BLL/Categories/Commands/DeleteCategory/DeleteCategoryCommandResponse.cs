using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommandResponse : CommandQueryResponseBase
{
    public int DeletedCount { get; init; }
}
