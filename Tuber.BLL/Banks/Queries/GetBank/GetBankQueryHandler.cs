﻿using MediatR;
using Tuber.Domain.DAL;

namespace Tuber.BLL.Banks.Queries.GetBank
{
    public class GetBankQueryHandler : IRequestHandler<GetBankQueryRequest, GetBankQueryResponse>
    {
        private readonly IRepo _bankRepo;

        public GetBankQueryHandler(IRepo bankRepo)
        {
            _bankRepo = bankRepo;
        }

        public Task<GetBankQueryResponse> Handle(GetBankQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetBankQueryResponse
            {
                BankCount = request.NumberOfDays,
                Bank = _bankRepo.Get(request.FromDate, request.NumberOfDays)
            });
        }
    }
}
