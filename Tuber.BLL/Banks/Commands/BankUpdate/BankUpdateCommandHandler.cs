using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Banks.Commands.BankUpdate
{
    public class BankUpdateCommandHandler : IRequestHandler<BankUpdateCommandRequest, BankUpdateCommandResponse>
    {
        private readonly IBankUpdaterService _bankUpdaterService;

        public BankUpdateCommandHandler(IBankUpdaterService bankUpdaterService)
        {
            _bankUpdaterService = bankUpdaterService;
        }

        public Task<BankUpdateCommandResponse> Handle(BankUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankUpdaterService.Update(
                bankId: request.BankId,
                name: request.Name,
                orderBy: request.OrderBy);

            return Task.FromResult(new BankUpdateCommandResponse
            {
                Id = serviceResult.Payload.BankId,
                Name = serviceResult.Payload.BankName,
                OrderBy = serviceResult.Payload.OrderBy,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
