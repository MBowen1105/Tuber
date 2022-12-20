using MediatR;

namespace Tuber.Application.Categories.Commands.CategoryAdd;
public class CategoryAddCommandRequest : IRequest<CategoryAddCommandResponse>
{
    public string CategoryName { get; set; } = "";
}
