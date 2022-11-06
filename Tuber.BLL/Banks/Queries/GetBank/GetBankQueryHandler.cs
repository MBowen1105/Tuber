using MediatR;
using Tuber.Domain.Interfaces.Services;

namespace Tuber.BLL.Banks.Queries.GetBank
{
    public class GetBankQueryHandler : IRequestHandler<GetBankQueryRequest, GetBankQueryResponse>
    {
        private readonly IBankService _bankService;

        public GetBankQueryHandler(IBankService bankService)
        {
            _bankService = bankService;
        }

        public Task<GetBankQueryResponse> Handle(GetBankQueryRequest request, CancellationToken cancellationToken)
        {
            var banks = _bankService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetBankQueryResponse
            {
                BankCount = banks.Count,
                Banks = banks,
                TotalPages = _bankService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
