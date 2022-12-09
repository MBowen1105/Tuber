using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.AddCategory;

public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommandRequest, AddCategoryCommandResponse>
{
    private readonly ICategoryUpdaterService _CategoryUpdaterService;

    public AddCategoryCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
    {
        _CategoryUpdaterService = CategoryUpdaterService;
    }

    public Task<AddCategoryCommandResponse> Handle(AddCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var categoryModel = _CategoryUpdaterService.Add(request.CategoryName);

        return Task.FromResult(new AddCategoryCommandResponse
        {
            CategoryId = categoryModel.CategoryId,
            CategoryName = categoryModel.CategoryName,
        });
    }
}
