using MediatR;
using Tuber.BLL.Banks.Commands;
using Tuber.Domain.Interfaces.Services;

namespace Tuber.BLL.Banks.Queries
{
    public class PutBankCommandHandler : IRequestHandler<PutBankCommandRequest, PutBankCommandResponse>
    {
        private readonly IBankService _bankService;

        public PutBankCommandHandler(IBankService bankService)
        {
            _bankService = bankService;
        }

        public Task<PutBankCommandResponse> Handle(PutBankCommandRequest request, CancellationToken cancellationToken)
        {
            var id = _bankService.Add(request.Name, request.OrderBy);

            return Task.FromResult(new PutBankCommandResponse
            {
                Id = id,
            });
        }
    }
}
