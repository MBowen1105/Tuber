using Tuber.Core.Common;

namespace Tuber.Application.Subcategories.Commands.SubcategoryUpdate;

public class SubcategoryUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
}
