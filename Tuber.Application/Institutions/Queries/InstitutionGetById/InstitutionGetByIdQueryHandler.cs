using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions.Queries.InstitutionGetById
{
    public class InstitutionGetByIdQueryHandler : IRequestHandler<InstitutionGetByIdQueryRequest, InstitutionGetByIdQueryResponse>
    {
        private readonly IInstitutionRetrievalService _institutionRetrieverService;
        private readonly IMapper _mapper;

        public InstitutionGetByIdQueryHandler(IInstitutionRetrievalService institutionRetrieverService, IMapper mapper)
        {
            _institutionRetrieverService = institutionRetrieverService;
            _mapper = mapper;
        }

        public Task<InstitutionGetByIdQueryResponse> Handle(InstitutionGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _institutionRetrieverService.GetById(request.InstitutionId);

            var response = _mapper.Map<Institution, InstitutionGetByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
