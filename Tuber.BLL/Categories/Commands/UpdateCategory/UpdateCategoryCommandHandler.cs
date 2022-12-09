using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
{
    private readonly ICategoryUpdaterService _CategoryUpdaterService;

    public UpdateCategoryCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
    {
        _CategoryUpdaterService = CategoryUpdaterService;
    }

    public Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var categoryModel = _CategoryUpdaterService.Update(request.CategoryId, request.CategoryName);

        return Task.FromResult(new UpdateCategoryCommandResponse
        {
            CategoryId = categoryModel.CategoryId,
            CategoryName = categoryModel.CategoryName,
        });
    }
}
