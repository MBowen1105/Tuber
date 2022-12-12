using MediatR;

namespace Tuber.BLL.Subcategories.Commands.AddSubcategory;
public class AddSubcategoryCommandRequest : IRequest<AddSubcategoryCommandResponse>
{
    public string SubcategoryName { get; set; } = "";
    public Guid CategoryId { get; set; }
}
