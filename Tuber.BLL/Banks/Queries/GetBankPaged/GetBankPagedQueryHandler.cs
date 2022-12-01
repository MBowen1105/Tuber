using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankPaged
{
    public class GetBankPagedQueryHandler : IRequestHandler<GetBankPagedQueryRequest, GetBankPagedQueryResponse>
    {
        private readonly IBankRetrievalService _bankRetrievalService;
        private readonly IMapper _mapper;

        public GetBankPagedQueryHandler(IBankRetrievalService bankRetrievalService, IMapper mapper)
        {
            _bankRetrievalService = bankRetrievalService;
            _mapper = mapper;
        }

        public Task<GetBankPagedQueryResponse> Handle(GetBankPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetBankPagedQueryResponse
            {
                BankCount = serviceResult.Payload.Count,
                Banks = _mapper.Map<List<Bank>, List<BankDto>>(serviceResult.Payload),
                TotalPages = _bankRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
