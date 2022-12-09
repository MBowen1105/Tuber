using MediatR;

namespace Tuber.BLL.Categories.Commands.AddCategory;
public class AddCategoryCommandRequest : IRequest<AddCategoryCommandResponse>
{
    public string CategoryName { get; set; } = "";
}
