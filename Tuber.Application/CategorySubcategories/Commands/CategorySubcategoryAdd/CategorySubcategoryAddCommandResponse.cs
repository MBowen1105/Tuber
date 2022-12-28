using Tuber.Core.Common;

namespace Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;

public class CategorySubcategoryAddCommandResponse : CommandQueryResponseBase
{
    public Guid CategorySubcategoryId { get; init; }
    public Guid CategoryId { get; init; }
    public Guid? SubcategoryId { get; init; }
}
