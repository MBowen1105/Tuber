using MediatR;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Queries.GetBankById
{
    public class GetBankByIdQueryHandler : IRequestHandler<GetBankByIdQueryRequest, GetBankByIdQueryResponse>
    {
        private readonly IBankService _bankService;

        public GetBankByIdQueryHandler(IBankService bankService)
        {
            _bankService = bankService;
        }

        public Task<GetBankByIdQueryResponse> Handle(GetBankByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bank = _bankService.GetById(request.BankId);

            var response = new GetBankByIdQueryResponse
            {
                Id = bank.Id,
                Name = bank.Name,
                OrderBy = bank.OrderBy,
                BankAccounts=bank.BankAccounts,
                IsArchived = bank.IsArchived
            };

            if (bank.Id == Guid.Empty)
                response.Exceptions.Add(new BankDoesNotExistException(request.BankId));

            return Task.FromResult(response);
        }
    }
}
