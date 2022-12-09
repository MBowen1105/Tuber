using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
}
