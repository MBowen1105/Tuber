using AutoMapper;
using MediatR;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.BankGetById
{
    public class BankGetByIdQueryHandler : IRequestHandler<BankGetByIdQueryRequest, BankGetByIdQueryResponse>
    {
        private readonly IBankRetrievalService _bankRetrieverService;
        private readonly IMapper _mapper;

        public BankGetByIdQueryHandler(IBankRetrievalService bankRetrieverService, IMapper mapper)
        {
            _bankRetrieverService = bankRetrieverService;
            _mapper = mapper;
        }

        public Task<BankGetByIdQueryResponse> Handle(BankGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankRetrieverService.GetById(request.BankId);

            var response = _mapper.Map<Bank, BankGetByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
