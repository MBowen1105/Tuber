using MediatR;

namespace Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddCommandRequest : IRequest<CategorySubcategoryAddCommandResponse>
{   public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
