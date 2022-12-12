using MediatR;

namespace Tuber.BLL.Subcategories.Queries.GetSubcategoryById;
public class GetSubcategoryByIdQueryRequest : IRequest<GetSubcategoryByIdQueryResponse>
{
    public Guid SubcategoryId { get; set; }
}
