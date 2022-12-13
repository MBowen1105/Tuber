using MediatR;

namespace Tuber.BLL.Subcategories.Queries.SubcategoryGetById;
public class SubcategoryGetByIdQueryRequest : IRequest<SubcategoryGetByIdQueryResponse>
{
    public Guid SubcategoryId { get; set; }
}
