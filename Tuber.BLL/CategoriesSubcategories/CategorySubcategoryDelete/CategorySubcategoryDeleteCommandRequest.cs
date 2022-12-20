using MediatR;

namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryDelete;
public class CategorySubcategoryDeleteCommandRequest : IRequest<CategorySubcategoryDeleteCommandResponse>
{
    public Guid CategorySubcategoryId { get; set; }
}
