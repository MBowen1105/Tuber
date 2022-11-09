using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged
{
    public class GetBankAccountPagedQueryHandler : IRequestHandler<GetBankAccountPagedQueryRequest, GetBankAccountPagedQueryResponse>
    {
        private readonly IBankAccountService _bankAccountService;

        public GetBankAccountPagedQueryHandler(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        public Task<GetBankAccountPagedQueryResponse> Handle(GetBankAccountPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var bankAccounts = _bankAccountService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetBankAccountPagedQueryResponse
            {
                BankAccountCount = bankAccounts.Count,
                BankAccounts = bankAccounts,
                TotalPages = _bankAccountService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
