using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.InstitutionAccounts.Commands.InstitutionAccountUpdate
{
    public class InstitutionAccountUpdateCommandHandler : IRequestHandler<InstitutionAccountUpdateCommandRequest, InstitutionAccountUpdateCommandResponse>
    {
        private readonly IInstitutionAccountUpdaterService _institutionAccountUpdaterService;

        public InstitutionAccountUpdateCommandHandler(IInstitutionAccountUpdaterService institutionAccountUpdaterService)
        {
            _institutionAccountUpdaterService = institutionAccountUpdaterService;
        }

        public Task<InstitutionAccountUpdateCommandResponse> Handle(InstitutionAccountUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            //TODO: Validate InstitutionAccount object

            var serviceResult = _institutionAccountUpdaterService.Update(
                request.InstitutionAccountId,
                request.InstitutionAccountName,
                request.UKSortCode, request.UKInstitutionAccount,
                request.OrderBy,
                request.ImportTemplateId,
                request.OpeningBalance);

            return Task.FromResult(new InstitutionAccountUpdateCommandResponse
            {
                InstitutionAccountId = serviceResult.Payload.InstitutionAccountId,
                InstitutionAccountName = serviceResult.Payload.InstitutionAccountName,
                OrderBy = serviceResult.Payload.OrderBy,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
