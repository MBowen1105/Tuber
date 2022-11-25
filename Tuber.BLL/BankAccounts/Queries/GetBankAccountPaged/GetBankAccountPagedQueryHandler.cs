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
            var bankAccountModelList = _bankAccountRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var bankAccountDtoList = _mapper.Map<List<BankAccount>, List<BankAccountDto>>(bankAccountModelList);
            
            var response = new GetBankAccountPagedQueryResponse
            {
                BankAccountCount = bankAccountModelList.Count,
                TotalPages = _bankAccountRetrieverService.CountPages(request.PageSize),
                BankAccounts = bankAccountDtoList
            };

            return Task.FromResult(response);
        }
    }
}
