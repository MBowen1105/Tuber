using MediatR;
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
            return Task.FromResult(new GetBankQueryResponse
            {
                BankCount = request.PageSize,
                Banks = _bankRepo.Get(request.PageNumber, request.PageSize)
            });
        }
    }
}
