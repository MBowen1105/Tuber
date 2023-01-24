using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers.Queries.LedgerGetPaged
{
    public class LedgerGetPagedQueryHandler : IRequestHandler<LedgerGetPagedQueryRequest, LedgerGetPagedQueryResponse>
    {
        private readonly ILedgerRetrievalService _ledgerRetrievalService;
        private readonly IMapper _mapper;

        public LedgerGetPagedQueryHandler(ILedgerRetrievalService LedgerRetrievalService, IMapper mapper)
        {
            _ledgerRetrievalService = LedgerRetrievalService;
            _mapper = mapper;
        }

        public Task<LedgerGetPagedQueryResponse> Handle(
            LedgerGetPagedQueryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceResult = _ledgerRetrievalService.GetPaged(
                request.BankAccountId, 
                request.PageNumber, 
                request.PageSize);

            var ledgerList = _mapper.Map<List<Ledger>, List<LedgerGetPaged_Ledger>>(serviceResult.Payload);

            var response = new LedgerGetPagedQueryResponse
            {
                LedgerCount = serviceResult.Payload.Count,
                Ledgers = ledgerList,
                TotalPages = _ledgerRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
