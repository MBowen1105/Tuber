﻿using MediatR;
using Tuber.BLL.Subcategories.Commands.SubcategoryDelete;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Commands.BankDelete
{
    public class BankDeleteCommandHandler : IRequestHandler<BankDeleteCommandRequest, BankDeleteCommandResponse>
    {
        private readonly IBankRetrievalService _bankRetrievalService;
        private readonly IBankUpdaterService _bankUpdaterService;

        public BankDeleteCommandHandler(
            IBankRetrievalService bankRetrievalService,
            IBankUpdaterService bankUpdaterService
            )
        {
            _bankUpdaterService = bankUpdaterService;
            _bankRetrievalService = bankRetrievalService;
        }

        public Task<BankDeleteCommandResponse> Handle(BankDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _bankRetrievalService.GetById(request.BankId);
            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new BankDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Bank.FriendlyName, request.BankId)));

            var serviceResultDelete = _bankUpdaterService.Delete(request.BankId);

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
