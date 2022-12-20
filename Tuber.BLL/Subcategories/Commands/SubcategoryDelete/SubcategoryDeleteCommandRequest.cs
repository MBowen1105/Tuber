using MediatR;

namespace Tuber.Application.Subcategories.Commands.SubcategoryDelete;
public class SubcategoryDeleteCommandRequest : IRequest<SubcategoryDeleteCommandResponse>
{
    public Guid SubcategoryId { get; set; }
}
