using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Institutions.Commands.InstitutionUpdate
{
    public class InstitutionUpdateCommandHandler : IRequestHandler<InstitutionUpdateCommandRequest, InstitutionUpdateCommandResponse>
    {
        private readonly IInstitutionUpdaterService _institutionUpdaterService;

        public InstitutionUpdateCommandHandler(IInstitutionUpdaterService institutionUpdaterService)
        {
            _institutionUpdaterService = institutionUpdaterService;
        }

        public Task<InstitutionUpdateCommandResponse> Handle(InstitutionUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _institutionUpdaterService.Update(
                institutionId: request.InstitutionId,
                name: request.InstitutionName,
                orderBy: request.OrderBy);

            return Task.FromResult(new InstitutionUpdateCommandResponse
            {
                InstitutionId = serviceResult.Payload.InstitutionId,
                InstitutionName = serviceResult.Payload.InstitutionName,
                OrderBy = serviceResult.Payload.OrderBy,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
