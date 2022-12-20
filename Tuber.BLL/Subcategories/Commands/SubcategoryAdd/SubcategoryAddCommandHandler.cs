using MediatR;
using Tuber.BLL.Interfaces;

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
        var serviceResult = _subcategoryUpdaterService.Add(request.SubcategoryName);

        return Task.FromResult(new SubcategoryAddCommandResponse
        {
            SubcategoryId = serviceResult.Payload.SubcategoryId,
            SubcategoryName = serviceResult.Payload.SubcategoryName,
            Exceptions = serviceResult.Exceptions,
        });
    }
}
