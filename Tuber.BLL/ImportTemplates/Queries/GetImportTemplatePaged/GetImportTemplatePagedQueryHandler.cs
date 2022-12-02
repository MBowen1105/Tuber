using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged
{
    public class GetImportTemplatePagedQueryHandler : IRequestHandler<GetImportTemplatePagedQueryRequest, GetImportTemplatePagedQueryResponse>
    {
        private readonly IImportTemplateRetrievalService _ImportTemplateRetrievalService;
        private readonly IMapper _mapper;

        public GetImportTemplatePagedQueryHandler(IImportTemplateRetrievalService ImportTemplateService, IMapper mapper)
        {
            _ImportTemplateRetrievalService = ImportTemplateService;
            this._mapper = mapper;
        }

        public Task<GetImportTemplatePagedQueryResponse> Handle(GetImportTemplatePagedQueryRequest request, CancellationToken cancellationToken)
        {
            var ImportTemplateServiceResult = _ImportTemplateRetrievalService.GetPaged(
                request.PageNumber, request.PageSize);

            var response = new GetImportTemplatePagedQueryResponse
            {
                ImportTemplateCount = ImportTemplateServiceResult.Payload.Count,
                ImportTemplates = _mapper.Map<List<ImportTemplate>, List<ImportTemplatePaged_ImportTemplate>>(ImportTemplateServiceResult.Payload),
                TotalPages = _ImportTemplateRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}