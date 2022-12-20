using MediatR;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryUpdate;
public class SubcategoryUpdateCommandRequest : IRequest<SubcategoryUpdateCommandResponse>
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
}
