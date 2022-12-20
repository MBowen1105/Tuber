using MediatR;

namespace Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryDelete;
public class CategorySubcategoryDeleteCommandRequest : IRequest<CategorySubcategoryDeleteCommandResponse>
{
    public Guid CategorySubcategoryId { get; set; }
}
