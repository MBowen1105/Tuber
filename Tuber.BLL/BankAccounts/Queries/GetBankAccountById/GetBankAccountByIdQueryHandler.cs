using AutoMapper;
using MediatR;
using Tuber.BLL.BankAccounts.Services;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountById
{
    public class GetBankAccountByIdQueryHandler : IRequestHandler<GetBankAccountByIdQueryRequest, GetBankAccountByIdQueryResponse>
    {
        private readonly IBankAccountRetrievalService _bankAccountRetrievalService;
        private readonly IMapper _mapper;

        public GetBankAccountByIdQueryHandler(
            IBankAccountRetrievalService bankAccountRetrievalService, IMapper mapper)
        {
            _bankAccountRetrievalService = bankAccountRetrievalService;
            _mapper = mapper;
        }

        public Task<GetBankAccountByIdQueryResponse> Handle(GetBankAccountByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrievalService.GetById(request.BankAccountId);

            var response = new GetBankAccountByIdQueryResponse
            {
                BankAccountId = serviceResult.Payload!.BankAccountId,
                Name = serviceResult.Payload!.Name!,
                OrderBy = serviceResult.Payload!.OrderBy,
                Exceptions = serviceResult.Exceptions
            };

            return Task.FromResult(response);
        }
    }
}
