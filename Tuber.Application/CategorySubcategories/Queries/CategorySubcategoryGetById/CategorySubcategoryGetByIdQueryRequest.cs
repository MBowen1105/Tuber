using MediatR;

namespace Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;
public class CategorySubcategoryGetByIdQueryRequest : IRequest<CategorySubcategoryGetByIdQueryResponse>
{
    public Guid CategorySubcategoryId { get; set; }
}
