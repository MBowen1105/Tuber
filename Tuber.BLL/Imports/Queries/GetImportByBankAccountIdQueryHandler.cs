using AutoMapper;
using MediatR;
using Tuber.BLL.Imports.Queries;
using Tuber.Domain.Dtos;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Queries.GetImportByBankAccountId
{
    public class GetImportByBankAccountIdQueryHandler : IRequestHandler<GetImportByBankAccountIdQueryRequest, GetImportByBankAccountIdQueryResponse>
    {
        private readonly IImportRetrievalService _importRetrieverService;
        private readonly IMapper _mapper;

        public GetImportByBankAccountIdQueryHandler(IImportRetrievalService importRetrieverService, IMapper mapper)
        {
            _importRetrieverService = importRetrieverService;
            _mapper = mapper;
        }

        public Task<GetImportByBankAccountIdQueryResponse> Handle(GetImportByBankAccountIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _importRetrieverService.GetByBankAccountId(request.BankAccountId);

            var importDtoList = _mapper.Map<List<Import>, List<ImportDto>>(serviceResult.Payload!);

            var response = new GetImportByBankAccountIdQueryResponse
            {
                Imports = importDtoList,
                Exceptions = serviceResult.Exceptions.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
