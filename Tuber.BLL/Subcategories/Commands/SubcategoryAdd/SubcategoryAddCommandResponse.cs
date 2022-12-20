using Tuber.Core.Common;

namespace Tuber.Application.Subcategories.Commands.SubcategoryAdd;

public class SubcategoryAddCommandResponse : CommandQueryResponseBase
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public Guid CategoryId { get; init; }
}
