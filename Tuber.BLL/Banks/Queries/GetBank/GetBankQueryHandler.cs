using MediatR;
using Tuber.Core.ValueObjects;
using Tuber.Domain.DAL;

namespace Tuber.BLL.Banks.Queries.GetBank
{
    public class GetBankQueryHandler : IRequestHandler<GetBankQueryRequest, GetBankQueryResponse>
    {
        private readonly IBankRepo _bankRepo;

        public GetBankQueryHandler(IBankRepo bankRepo)
        {
            _bankRepo = bankRepo;
        }

        public Task<GetBankQueryResponse> Handle(GetBankQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new GetBankQueryResponse
            {
                BankCount = request.PageSize,
                Banks = _bankRepo.Get(request.PageNumber, request.PageSize),
                TotalPages = 10
            };

            return Task.FromResult(response);
        }
    }
}
