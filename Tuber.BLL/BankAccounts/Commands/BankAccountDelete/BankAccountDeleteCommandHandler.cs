using MediatR;
using Tuber.Core.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Commands.BankAccountDelete
{
    public class BankAccountDeleteCommandHandler : IRequestHandler<BankAccountDeleteCommandRequest, BankAccountDeleteCommandResponse>
    {
        private readonly IBankAccountDeletionService _bankAccountDeletionService;

        public BankAccountDeleteCommandHandler(
            IBankAccountDeletionService bankAccountDeletionService
            )
        {
            _bankAccountDeletionService = bankAccountDeletionService;
        }

        public Task<BankAccountDeleteCommandResponse> Handle(BankAccountDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountDeletionService.Delete(request.BankAccountId);

            return Task.FromResult(
                new BankAccountDeleteCommandResponse(serviceResult.Payload, serviceResult.Exceptions));
        }
    }
}
