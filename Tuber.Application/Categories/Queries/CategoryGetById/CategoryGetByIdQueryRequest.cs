using MediatR;

namespace Tuber.Application.Categories.Queries.CategoryGetById;
public class CategoryGetByIdQueryRequest : IRequest<CategoryGetByIdQueryResponse>
{
    public Guid CategoryId { get; set; }
}
