using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.InstitutionAccounts.Commands.InstitutionAccountUpdate
{
    public class InstitutionAccountUpdateCommandHandler : IRequestHandler<InstitutionAccountUpdateCommandRequest, InstitutionAccountUpdateCommandResponse>
    {
        private readonly IInstitutionAccountUpdaterService _bankAccountUpdaterService;

        public InstitutionAccountUpdateCommandHandler(IInstitutionAccountUpdaterService bankAccountUpdaterService)
        {
            _bankAccountUpdaterService = bankAccountUpdaterService;
        }

        public Task<InstitutionAccountUpdateCommandResponse> Handle(InstitutionAccountUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            //TODO: Validate InstitutionAccount object

            var serviceResult = _bankAccountUpdaterService.Update(
                bankAccountId: request.InstitutionAccountId,
                bankAccountName: request.InstitutionAccountName,
                orderBy: request.OrderBy);

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
