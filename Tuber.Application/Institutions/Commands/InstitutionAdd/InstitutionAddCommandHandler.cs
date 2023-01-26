using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Institutions.Commands.InstitutionAdd;

public class InstitutionAddCommandHandler : IRequestHandler<InstitutionAddCommandRequest, InstitutionAddCommandResponse>
{
    private readonly IInstitutionUpdaterService _bankUpdaterService;

    public InstitutionAddCommandHandler(IInstitutionUpdaterService bankUpdaterService)
    {
        _bankUpdaterService = bankUpdaterService;
    }

    public Task<InstitutionAddCommandResponse> Handle(InstitutionAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _bankUpdaterService.Add(request.InstitutionName, request.OrderBy);

        return Task.FromResult(new InstitutionAddCommandResponse
        {
            InstitutionId = serviceResult.Payload.InstitutionId,
            InstitutionName = serviceResult.Payload.InstitutionName!,
            OrderBy = serviceResult.Payload.OrderBy,
        });
    }
}
