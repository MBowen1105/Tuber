using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.CategoryUpdate;

public class CategoryUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
}
