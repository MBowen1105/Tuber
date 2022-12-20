using MediatR;
using Tuber.BLL.Interfaces;

namespace Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryAdd;

public class CategorySubcategoryAddCommandHandler : IRequestHandler<CategorySubcategoryAddCommandRequest, CategorySubcategoryAddCommandResponse>
{
    private readonly ICategorySubcategoryUpdaterService _subcategoryUpdaterService;

    public CategorySubcategoryAddCommandHandler(ICategorySubcategoryUpdaterService subcategoryUpdaterService)
    {
        _subcategoryUpdaterService = subcategoryUpdaterService;
    }

    public Task<CategorySubcategoryAddCommandResponse> Handle(CategorySubcategoryAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _subcategoryUpdaterService.Add(request.CategoryId, request.SubcategoryId);

        return Task.FromResult(new CategorySubcategoryAddCommandResponse
        {
            CategorySubcategoryId = serviceResult.Payload.CategorySubcategoryId,
            CategoryId = serviceResult.Payload.CategoryId,
            SubcategoryId = serviceResult.Payload.SubcategoryId,
            Exceptions = serviceResult.Exceptions,
        });
    }
}
