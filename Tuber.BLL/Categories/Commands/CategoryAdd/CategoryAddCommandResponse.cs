using Tuber.Core.Common;

namespace Tuber.BLL.Categories.Commands.CategoryAdd;

public class CategoryAddCommandResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
}
