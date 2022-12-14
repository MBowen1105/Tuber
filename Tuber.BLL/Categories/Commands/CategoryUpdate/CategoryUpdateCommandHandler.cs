using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.CategoryUpdate;

public class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommandRequest, CategoryUpdateCommandResponse>
{
    private readonly ICategoryUpdaterService _CategoryUpdaterService;

    public CategoryUpdateCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
    {
        _CategoryUpdaterService = CategoryUpdaterService;
    }

    public Task<CategoryUpdateCommandResponse> Handle(CategoryUpdateCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _CategoryUpdaterService.Update(request.CategoryId, request.CategoryName);

        return Task.FromResult(new CategoryUpdateCommandResponse
        {
            CategoryId = serviceResult.Payload.CategoryId,
            CategoryName = serviceResult.Payload.CategoryName,
            Exceptions = serviceResult.Exceptions,
        });
    }
}
