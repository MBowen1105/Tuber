using MediatR;
using Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;

namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddCommandRequest : IRequest<CategorySubcategoryAddCommandResponse>
{
    public Guid CategoryId { get; init; }
    public Guid SubcategoryId { get; init; }
}
