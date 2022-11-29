using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankById
{
    public class GetBankByIdQueryHandler : IRequestHandler<GetBankByIdQueryRequest, GetBankByIdQueryResponse>
    {
        private readonly IBankRetrievalService _bankRetrieverService;
        private readonly IMapper _mapper;

        public GetBankByIdQueryHandler(IBankRetrievalService bankRetrieverService, IMapper mapper)
        {
            _bankRetrieverService = bankRetrieverService;
            _mapper = mapper;
        }

        public Task<GetBankByIdQueryResponse> Handle(GetBankByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankRetrieverService.GetById(request.BankId);

            var bankAccountDtoList = _mapper.Map<List<BankAccount>, List<BankAccountDto>>(serviceResult.Payload!.BankAccounts!.ToList());

            var response = new GetBankByIdQueryResponse
            {
                Id = serviceResult.Payload!.BankId,
                Name = serviceResult.Payload!.Name!,
                OrderBy = serviceResult.Payload!.OrderBy,
                BankAccounts = bankAccountDtoList,
                Exceptions = serviceResult.Exceptions
            };

            return Task.FromResult(response);
        }
    }
}
