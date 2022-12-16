using MediatR;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryDelete;
public class SubcategoryDeleteCommandRequest : IRequest<SubcategoryDeleteCommandResponse>
{
    public Guid SubcategoryId { get; set; }
}
