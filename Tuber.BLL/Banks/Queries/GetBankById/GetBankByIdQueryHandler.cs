using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankById
{
    public class GetBankByIdQueryHandler : IRequestHandler<GetBankByIdQueryRequest, GetBankByIdQueryResponse>
    {
        private readonly IBankRetrieverService _bankRetrieverService;
        private readonly IMapper _mapper;

        public GetBankByIdQueryHandler(IBankRetrieverService bankRetrieverService, IMapper mapper)
        {
            _bankRetrieverService = bankRetrieverService;
            _mapper = mapper;
        }

        public Task<GetBankByIdQueryResponse> Handle(GetBankByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bankModel = _bankRetrieverService.GetById(request.BankId);

            var bankAccountDtoList = _mapper.Map<List<BankAccount>, List<BankAccountDto>>(bankModel.BankAccounts!.ToList());

            var response = new GetBankByIdQueryResponse
            {
                Id = bankModel.Id,
                Name = bankModel.Name!,
                OrderBy = bankModel.OrderBy,
                BankAccounts = bankAccountDtoList
            };

            if (bankModel.Id == Guid.Empty)
                response.Exceptions.Add(new BankDoesNotExistException(request.BankId));

            return Task.FromResult(response);
        }
    }
}
