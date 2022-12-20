using MediatR;

namespace Tuber.Application.Subcategories.Queries.SubcategoryGetById;
public class SubcategoryGetByIdQueryRequest : IRequest<SubcategoryGetByIdQueryResponse>
{
    public Guid SubcategoryId { get; set; }
}
