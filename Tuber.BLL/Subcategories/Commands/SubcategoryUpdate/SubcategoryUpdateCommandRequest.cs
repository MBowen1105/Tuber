using MediatR;

namespace Tuber.Application.Subcategories.Commands.SubcategoryUpdate;
public class SubcategoryUpdateCommandRequest : IRequest<SubcategoryUpdateCommandResponse>
{
    public Guid SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
}
