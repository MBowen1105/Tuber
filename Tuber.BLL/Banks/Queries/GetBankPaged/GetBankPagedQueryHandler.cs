using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankPaged
{
    public class GetBankPagedQueryHandler : IRequestHandler<GetBankPagedQueryRequest, GetBankPagedQueryResponse>
    {
        private readonly IBankRetrieverService _bankRetrieverService;
        private readonly IMapper _mapper;

        public GetBankPagedQueryHandler(IBankRetrieverService bankService, IMapper mapper)
        {
            _bankRetrieverService = bankService;
            this._mapper = mapper;
        }

        public Task<GetBankPagedQueryResponse> Handle(GetBankPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var bankModelList = _bankRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var bankDtoList = _mapper.Map<List<Bank>, List<BankDto>>(bankModelList);

            var response = new GetBankPagedQueryResponse
            {
                BankCount = bankModelList.Count,
                Banks = bankDtoList,
                TotalPages = _bankRetrieverService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
