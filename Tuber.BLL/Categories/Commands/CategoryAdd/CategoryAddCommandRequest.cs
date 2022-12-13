using MediatR;

namespace Tuber.BLL.Categories.Commands.CategoryAdd;
public class CategoryAddCommandRequest : IRequest<CategoryAddCommandResponse>
{
    public string CategoryName { get; set; } = "";
}
