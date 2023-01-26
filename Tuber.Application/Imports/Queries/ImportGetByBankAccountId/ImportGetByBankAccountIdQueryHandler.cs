using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Enums;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId
{
    public class ImportGetByInstitutionAccountIdQueryHandler : IRequestHandler<ImportGetByInstitutionAccountIdQueryRequest, ImportGetByInstitutionAccountIdQueryResponse>
    {
        private readonly IImportRetrievalService _importRetrievalService;
        private readonly IMapper _mapper;

        public ImportGetByInstitutionAccountIdQueryHandler(
            IImportRetrievalService importRetrievalService, IMapper mapper)
        {
            _importRetrievalService = importRetrievalService;
            _mapper = mapper;
        }

        public Task<ImportGetByInstitutionAccountIdQueryResponse> Handle(ImportGetByInstitutionAccountIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _importRetrievalService.GetByInstitutionAccountId(request.InstitutionAccountId);

            var importDtoList = _mapper.Map<List<Import>, List<GetImportByInstitutionAccountId_Import>>(serviceResult.Payload!);

            var response = new ImportGetByInstitutionAccountIdQueryResponse
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
