using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById
{
    public class InstitutionAccountGetByIdQueryHandler : IRequestHandler<InstitutionAccountGetByIdQueryRequest, InstitutionAccountGetByIdQueryResponse>
    {
        private readonly IInstitutionAccountRetrievalService _bankAccountRetrievalService;
        private readonly IMapper _mapper;

        public InstitutionAccountGetByIdQueryHandler(
            IInstitutionAccountRetrievalService bankAccountRetrievalService, IMapper mapper)
        {
            _bankAccountRetrievalService = bankAccountRetrievalService;
            _mapper = mapper;
        }

        public Task<InstitutionAccountGetByIdQueryResponse> Handle(InstitutionAccountGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrievalService.GetById(request.InstitutionAccountId);

            var response = _mapper.Map<InstitutionAccount, InstitutionAccountGetByIdQueryResponse>(serviceResult.Payload);
            
            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
