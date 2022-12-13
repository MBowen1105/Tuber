﻿using MediatR;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Commands.BankDelete
{
    public class BankDeleteCommandHandler : IRequestHandler<BankDeleteCommandRequest, BankDeleteCommandResponse>
    {
        private readonly IBankUpdaterService _bankUpdaterService;

        public BankDeleteCommandHandler(IBankUpdaterService bankUpdaterService)
        {
            _bankUpdaterService = bankUpdaterService;
        }

        public Task<BankDeleteCommandResponse> Handle(BankDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var result = _bankUpdaterService.Delete(request.Id);

            return Task.FromResult(new BankDeleteCommandResponse
            {
                DeletedCount = result,
                Exceptions = (result == 0)
                    ? new List<Exception>
                        {
                                new EntityToDeleteDoesNotExistException("Banks", request.Id)
                        }
                    : new List<Exception>()
            });
        }
    }
}