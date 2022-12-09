using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.AddCategory;

public class AddCategoryCommandResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
}
