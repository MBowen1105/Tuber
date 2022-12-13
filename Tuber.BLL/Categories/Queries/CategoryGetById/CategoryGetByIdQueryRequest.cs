using MediatR;

namespace Tuber.BLL.Categories.Queries.CategoryGetById;
public class CategoryGetByIdQueryRequest : IRequest<CategoryGetByIdQueryResponse>
{
    public Guid CategoryId { get; set; }
}
