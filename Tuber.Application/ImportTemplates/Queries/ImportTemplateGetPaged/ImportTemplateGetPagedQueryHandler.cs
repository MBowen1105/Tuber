using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Dtos;
using Tuber.Application.Models;

namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetPaged
{
    public class ImportTemplateGetPagedQueryHandler : IRequestHandler<ImportTemplateGetPagedQueryRequest, ImportTemplateGetPagedQueryResponse>
    {
        private readonly IImportTemplateRetrievalService _ImportTemplateRetrievalService;
        private readonly IMapper _mapper;

        public ImportTemplateGetPagedQueryHandler(IImportTemplateRetrievalService ImportTemplateService, IMapper mapper)
        {
            _ImportTemplateRetrievalService = ImportTemplateService;
            this._mapper = mapper;
        }

        public Task<ImportTemplateGetPagedQueryResponse> Handle(ImportTemplateGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var ImportTemplateServiceResult = _ImportTemplateRetrievalService.GetPaged(
                request.PageNumber, request.PageSize);

            return Task.FromResult(new ImportTemplateGetPagedQueryResponse
            {
                ImportTemplateCount = ImportTemplateServiceResult.Payload.Count,
                ImportTemplates = _mapper.Map<List<ImportTemplate>, List<ImportTemplateGetPaged_ImportTemplate>>(ImportTemplateServiceResult.Payload),
                TotalPages = _ImportTemplateRetrievalService.CountPages(request.PageSize)
            });
        }
    }
}