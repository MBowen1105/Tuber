using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Queries.GetBankPaged
{
    public class GetBankPagedQueryHandler : IRequestHandler<GetBankPagedQueryRequest, GetBankPagedQueryResponse>
    {
        private readonly IBankService _bankService;

        public GetBankPagedQueryHandler(IBankService bankService)
        {
            _bankService = bankService;
        }

        public Task<GetBankPagedQueryResponse> Handle(GetBankPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var banks = _bankService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetBankPagedQueryResponse
            {
                BankCount = banks.Count,
                Banks = banks,
                TotalPages = _bankService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
