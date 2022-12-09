using MediatR;

namespace Tuber.BLL.Categories.Commands.UpdateCategory;
public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = "";
}
