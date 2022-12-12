using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Subcategories.Commands.AddSubcategory;

public class AddSubcategoryCommandHandler : IRequestHandler<AddSubcategoryCommandRequest, AddSubcategoryCommandResponse>
{
    private readonly ISubcategoryUpdaterService _subcategoryUpdaterService;

    public AddSubcategoryCommandHandler(ISubcategoryUpdaterService subcategoryUpdaterService)
    {
        _subcategoryUpdaterService = subcategoryUpdaterService;
    }

    public Task<AddSubcategoryCommandResponse> Handle(AddSubcategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var subcategoryModel = _subcategoryUpdaterService.Add(request.SubcategoryName);

        return Task.FromResult(new AddSubcategoryCommandResponse
        {
            SubcategoryId = subcategoryModel.SubcategoryId,
            SubcategoryName = subcategoryModel.SubcategoryName,
        });
    }
}
