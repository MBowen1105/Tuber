using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged
{
    public class GetImportTemplatePagedQueryHandler : IRequestHandler<GetImportTemplatePagedQueryRequest, GetImportTemplatePagedQueryResponse>
    {
        private readonly IImportTemplateRetrievalService _ImportTemplateRetrieverService;
        private readonly IMapper _mapper;

        public GetImportTemplatePagedQueryHandler(IImportTemplateRetrievalService ImportTemplateService, IMapper mapper)
        {
            _ImportTemplateRetrieverService = ImportTemplateService;
            this._mapper = mapper;
        }

        public Task<GetImportTemplatePagedQueryResponse> Handle(GetImportTemplatePagedQueryRequest request, CancellationToken cancellationToken)
        {
            var ImportTemplateModelList = _ImportTemplateRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var ImportTemplateDtoList = _mapper.Map<List<ImportTemplate>, List<ImportTemplateDto>>(ImportTemplateModelList);

            var response = new GetImportTemplatePagedQueryResponse
            {
                ImportTemplateCount = ImportTemplateModelList.Count,
                ImportTemplates = ImportTemplateDtoList,
                TotalPages = _ImportTemplateRetrieverService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}