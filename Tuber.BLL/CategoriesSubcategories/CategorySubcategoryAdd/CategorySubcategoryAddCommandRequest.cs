using MediatR;

namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddCommandRequest : IRequest<CategorySubcategoryAddCommandResponse>
{   public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
