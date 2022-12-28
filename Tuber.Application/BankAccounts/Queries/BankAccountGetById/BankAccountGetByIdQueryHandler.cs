using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Models;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetById
{
    public class BankAccountGetByIdQueryHandler : IRequestHandler<BankAccountGetByIdQueryRequest, BankAccountGetByIdQueryResponse>
    {
        private readonly IBankAccountRetrievalService _bankAccountRetrievalService;
        private readonly IMapper _mapper;

        public BankAccountGetByIdQueryHandler(
            IBankAccountRetrievalService bankAccountRetrievalService, IMapper mapper)
        {
            _bankAccountRetrievalService = bankAccountRetrievalService;
            _mapper = mapper;
        }

        public Task<BankAccountGetByIdQueryResponse> Handle(BankAccountGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrievalService.GetById(request.BankAccountId);

            var response = _mapper.Map<BankAccount, BankAccountGetByIdQueryResponse>(serviceResult.Payload);
            
            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
