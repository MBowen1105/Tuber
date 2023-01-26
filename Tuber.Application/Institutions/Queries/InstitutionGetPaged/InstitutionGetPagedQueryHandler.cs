using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions.Queries.InstitutionGetPaged
{
    public class InstitutionGetPagedQueryHandler : IRequestHandler<InstitutionGetPagedQueryRequest, InstitutionGetPagedQueryResponse>
    {
        private readonly IInstitutionRetrievalService _bankRetrievalService;
        private readonly IMapper _mapper;

        public InstitutionGetPagedQueryHandler(IInstitutionRetrievalService bankRetrievalService, IMapper mapper)
        {
            _bankRetrievalService = bankRetrievalService;
            _mapper = mapper;
        }

        public Task<InstitutionGetPagedQueryResponse> Handle(InstitutionGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new InstitutionGetPagedQueryResponse
            {
                InstitutionCount = serviceResult.Payload.Count,
                Institutions = _mapper.Map<List<Institution>, List<InstitutionGetPaged_Institution>>(serviceResult.Payload),
                TotalPages = _bankRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
