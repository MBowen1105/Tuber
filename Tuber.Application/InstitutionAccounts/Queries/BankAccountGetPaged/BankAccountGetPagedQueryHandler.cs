using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged
{
    public class InstitutionAccountGetPagedQueryHandler : IRequestHandler<InstitutionAccountGetPagedQueryRequest, InstitutionAccountGetPagedQueryResponse>
    {
        private readonly IInstitutionAccountRetrievalService _bankAccountRetrieverService;
        private readonly IMapper _mapper;

        public InstitutionAccountGetPagedQueryHandler(IInstitutionAccountRetrievalService bankAccountRetrieverService,
            IMapper mapper)
        {
            _bankAccountRetrieverService = bankAccountRetrieverService;
            _mapper = mapper;
        }

        public Task<InstitutionAccountGetPagedQueryResponse> Handle(InstitutionAccountGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var response = new InstitutionAccountGetPagedQueryResponse
            {
                InstitutionAccountCount = serviceResult.Payload.Count,
                TotalPages = _bankAccountRetrieverService.CountPages(request.PageSize),
                InstitutionAccounts = _mapper.Map<List<InstitutionAccount>, List<InstitutionAccountGetPaged_InstitutionAccount>>(serviceResult.Payload)
            };

            return Task.FromResult(response);
        }
    }
}
