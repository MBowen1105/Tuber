using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.BankAccounts.Commands.BankAccountUpdate
{
    public class BankAccountUpdateCommandHandler : IRequestHandler<BankAccountUpdateCommandRequest, BankAccountUpdateCommandResponse>
    {
        private readonly IBankAccountUpdaterService _bankAccountUpdaterService;

        public BankAccountUpdateCommandHandler(IBankAccountUpdaterService bankAccountUpdaterService)
        {
            _bankAccountUpdaterService = bankAccountUpdaterService;
        }

        public Task<BankAccountUpdateCommandResponse> Handle(BankAccountUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            //TODO: Validate BankAccount object

            var serviceResult = _bankAccountUpdaterService.Update(
                bankAccountId: request.BankAccountId,
                bankAccountName: request.BankAccountName,
                orderBy: request.OrderBy);

            return Task.FromResult(new BankAccountUpdateCommandResponse
            {
                BankAccountId = serviceResult.Payload.BankAccountId,
                BankAccountName = serviceResult.Payload.BankAccountName,
                OrderBy = serviceResult.Payload.OrderBy,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
