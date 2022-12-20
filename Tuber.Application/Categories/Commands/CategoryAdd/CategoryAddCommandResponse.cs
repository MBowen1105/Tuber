using Tuber.Core.Common;

namespace Tuber.Application.Categories.Commands.CategoryAdd;

public class CategoryAddCommandResponse : CommandQueryResponseBase
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
}
