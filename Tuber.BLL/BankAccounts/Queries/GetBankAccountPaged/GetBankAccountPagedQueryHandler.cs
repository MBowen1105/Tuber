using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged
{
    public class GetBankAccountPagedQueryHandler : IRequestHandler<GetBankAccountPagedQueryRequest, GetBankAccountPagedQueryResponse>
    {
        private readonly IBankAccountRetrievalService _bankAccountRetrieverService;
        private readonly IMapper _mapper;

        public GetBankAccountPagedQueryHandler(IBankAccountRetrievalService bankAccountRetrieverService,
            IMapper mapper)
        {
            _bankAccountRetrieverService = bankAccountRetrieverService;
            _mapper = mapper;
        }

        public Task<GetBankAccountPagedQueryResponse> Handle(GetBankAccountPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetBankAccountPagedQueryResponse
            {
                BankAccountCount = serviceResult.Payload.Count,
                TotalPages = _bankAccountRetrieverService.CountPages(request.PageSize),
                BankAccounts = _mapper.Map<List<BankAccount>, List<GetBankAccountPaged_BankAccount>>(serviceResult.Payload)
            };

            return Task.FromResult(response);
        }
    }
}
