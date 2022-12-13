using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryAdd;

public class SubcategoryAddCommandHandler : IRequestHandler<SubcategoryAddCommandRequest, SubcategoryAddCommandResponse>
{
    private readonly ISubcategoryUpdaterService _subcategoryUpdaterService;

    public SubcategoryAddCommandHandler(ISubcategoryUpdaterService subcategoryUpdaterService)
    {
        _subcategoryUpdaterService = subcategoryUpdaterService;
    }

    public Task<SubcategoryAddCommandResponse> Handle(SubcategoryAddCommandRequest request, CancellationToken cancellationToken)
    {
        var subcategoryModel = _subcategoryUpdaterService.Add(request.SubcategoryName);

        return Task.FromResult(new SubcategoryAddCommandResponse
        {
            SubcategoryId = subcategoryModel.SubcategoryId,
            SubcategoryName = subcategoryModel.SubcategoryName,
        });
    }
}
