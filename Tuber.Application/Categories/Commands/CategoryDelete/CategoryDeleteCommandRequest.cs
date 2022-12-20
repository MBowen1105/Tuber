using MediatR;

namespace Tuber.Application.Categories.Commands.CategoryDelete;
public class CategoryDeleteCommandRequest : IRequest<CategoryDeleteCommandResponse>
{
    public Guid CategoryId { get; set; }
}
