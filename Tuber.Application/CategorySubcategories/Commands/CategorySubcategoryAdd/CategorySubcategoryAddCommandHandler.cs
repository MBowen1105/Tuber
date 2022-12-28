using MediatR;
using Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;

public class CategorySubcategoryAddCommandHandler : IRequestHandler<CategorySubcategoryAddCommandRequest, CategorySubcategoryAddCommandResponse>
{
    private readonly ICategorySubcategoryUpdaterService _categorySubcategoryUpdaterService;

    public CategorySubcategoryAddCommandHandler(ICategorySubcategoryUpdaterService categorySubcategoryUpdaterService)
    {
        _categorySubcategoryUpdaterService = categorySubcategoryUpdaterService;
    }

    public Task<CategorySubcategoryAddCommandResponse> Handle(CategorySubcategoryAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _categorySubcategoryUpdaterService.Add(request.CategoryId, request.SubcategoryId);

        return Task.FromResult(new CategorySubcategoryAddCommandResponse
        {
            CategorySubcategoryId = serviceResult.Payload.CategorySubcategoryId,
            CategoryId = serviceResult.Payload.CategoryId,
            SubcategoryId = serviceResult.Payload.SubcategoryId,
            Exceptions = serviceResult.Exceptions,
        });
    }
}
