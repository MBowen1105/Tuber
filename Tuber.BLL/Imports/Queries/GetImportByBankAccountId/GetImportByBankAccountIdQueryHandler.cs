﻿using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Enums;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Queries.GetImportByBankAccountId
{
    public class GetImportByBankAccountIdQueryHandler : IRequestHandler<GetImportByBankAccountIdQueryRequest, GetImportByBankAccountIdQueryResponse>
    {
        private readonly IImportRetrievalService _importRetrievalService;
        private readonly IMapper _mapper;

        public GetImportByBankAccountIdQueryHandler(
            IImportRetrievalService importRetrievalService, IMapper mapper)
        {
            _importRetrievalService = importRetrievalService;
            _mapper = mapper;
        }

        public Task<GetImportByBankAccountIdQueryResponse> Handle(GetImportByBankAccountIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _importRetrievalService.GetByBankAccountId(request.BankAccountId);

            var importDtoList = _mapper.Map<List<Import>, List<GetImportByBankAccountId_Import>>(serviceResult.Payload!);

            var response = new GetImportByBankAccountIdQueryResponse
            {
                TotalImportRowCount = importDtoList.Count,
                ValidImportRowCount = importDtoList.Count(x => x.ImportRowStatus == ImportRowStatus.IsValid),
                InvalidImportRowCount = importDtoList.Count(x => x.ImportRowStatus == ImportRowStatus.IsInvalid),
                Imports = importDtoList,
                Exceptions = serviceResult.Exceptions.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
