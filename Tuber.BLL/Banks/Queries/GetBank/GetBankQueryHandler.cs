﻿using MediatR;
using Tuber.Domain;

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
            var response = new GetBankQueryResponse
            {
                BankCount = request.PageSize,
                Banks = _bankService.GetPaged(request.PageNumber, request.PageSize),
                TotalPages = _bankService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
