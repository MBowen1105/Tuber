using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Banks.Queries.BankGetPaged
{
    public class BankGetPagedQueryHandler : IRequestHandler<BankGetPagedQueryRequest, BankGetPagedQueryResponse>
    {
        private readonly IBankRetrievalService _bankRetrievalService;
        private readonly IMapper _mapper;

        public BankGetPagedQueryHandler(IBankRetrievalService bankRetrievalService, IMapper mapper)
        {
            _bankRetrievalService = bankRetrievalService;
            _mapper = mapper;
        }

        public Task<BankGetPagedQueryResponse> Handle(BankGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new BankGetPagedQueryResponse
            {
                BankCount = serviceResult.Payload.Count,
                Banks = _mapper.Map<List<Bank>, List<BankGetPaged_Bank>>(serviceResult.Payload),
                TotalPages = _bankRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
