using MediatR;

namespace Tuber.BLL.Categories.Commands.CategoryDelete;
public class CategoryDeleteCommandRequest : IRequest<CategoryDeleteCommandResponse>
{
    public Guid CategoryId { get; set; }
}
