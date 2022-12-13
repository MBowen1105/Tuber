using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.CategoryAdd;

public class CategoryAddCommandHandler : IRequestHandler<CategoryAddCommandRequest, CategoryAddCommandResponse>
{
    private readonly ICategoryUpdaterService _CategoryUpdaterService;

    public CategoryAddCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
    {
        _CategoryUpdaterService = CategoryUpdaterService;
    }

    public Task<CategoryAddCommandResponse> Handle(CategoryAddCommandRequest request, CancellationToken cancellationToken)
    {
        var categoryModel = _CategoryUpdaterService.Add(request.CategoryName);

        return Task.FromResult(new CategoryAddCommandResponse
        {
            CategoryId = categoryModel.CategoryId,
            CategoryName = categoryModel.CategoryName,
        });
    }
}
