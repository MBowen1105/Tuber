using MediatR;
using Tuber.Application.BankAccounts.Commands.BankAccountDelete;
using Tuber.Core.Exceptions;
using Tuber.Domain.Common;
using Tuber.Domain.Models;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Banks.Commands.BankDelete
{
    public class BankDeleteCommandHandler : IRequestHandler<BankDeleteCommandRequest, BankDeleteCommandResponse>
    {
        private readonly IBankDeletionService _bankDeletionService;

        public BankDeleteCommandHandler(
            IBankDeletionService bankDeletionService
            )
        {
            _bankDeletionService = bankDeletionService;
        }

        public Task<BankDeleteCommandResponse> Handle(BankDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankDeletionService.Delete(request.BankId);
            
            return Task.FromResult(
            new BankDeleteCommandResponse(serviceResult.Payload, serviceResult.Exceptions));

        }
    }
}
