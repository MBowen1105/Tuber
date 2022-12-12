using Tuber.Core.Common;

namespace Tuber.BLL.Subcategories.Commands.AddSubcategory;

public class AddSubcategoryCommandResponse : CommandQueryResponseBase
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public Guid CategoryId { get; init; }
}
