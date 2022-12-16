using MediatR;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryAdd;
public class SubcategoryAddCommandRequest : IRequest<SubcategoryAddCommandResponse>
{
    public string SubcategoryName { get; set; } = "";
    public Guid CategoryId { get; set; }
}
