using MediatR;

namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryDelete;
public class CategorySubcategoryDeleteCommandRequest : IRequest<CategorySubcategoryDeleteCommandResponse>
{
    public Guid CategorySubcategoryId { get; set; }
}
