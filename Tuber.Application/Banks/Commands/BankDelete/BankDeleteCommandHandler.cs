using MediatR;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.Application.Banks.Commands.BankDelete
{
    public class BankDeleteCommandHandler : IRequestHandler<BankDeleteCommandRequest, BankDeleteCommandResponse>
    {
        private readonly IBankRetrievalService _bankRetrievalService;
        private readonly IBankDeletionService _bankDeletionService;

        public BankDeleteCommandHandler(
            IBankRetrievalService bankRetrievalService,
            IBankDeletionService bankDeletionService
            )
        {
            _bankDeletionService = bankDeletionService;
            _bankRetrievalService = bankRetrievalService;
        }

        public Task<BankDeleteCommandResponse> Handle(BankDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _bankRetrievalService.GetById(request.BankId);
            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new BankDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Bank.FriendlyName, request.BankId)));

            var serviceResultDelete = _bankDeletionService.Delete(request.BankId);

            if (serviceResultDelete.HasFailed)
                return Task.FromResult(new BankDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Bank.FriendlyName, request.BankId)));

            return Task.FromResult(new BankDeleteCommandResponse
            {
                DeletedCount = serviceResultDelete.Payload
            });
        }
    }
}
