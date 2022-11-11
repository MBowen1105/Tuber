using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Commands.PutBank
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
            var bank = _bankService.Add(request.Name, request.OrderBy);

            return Task.FromResult(new PutBankCommandResponse
            {
                Id = bank.Id,
                Name = bank.Name,
                OrderBy = bank.OrderBy,
                CreatedByUserId = bank.CreatedByUserId,
                CreatedOn = bank.CreatedOn,
                UpdatedByUserId = bank.UpdatedByUserId,
                UpdatedOn = bank.UpdatedOn
            });
        }
    }
}
