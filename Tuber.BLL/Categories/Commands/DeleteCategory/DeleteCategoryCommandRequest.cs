using MediatR;

namespace Tuber.BLL.Categories.Commands.DeleteCategory;
public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
{
    public Guid CategoryId { get; set; }
}
