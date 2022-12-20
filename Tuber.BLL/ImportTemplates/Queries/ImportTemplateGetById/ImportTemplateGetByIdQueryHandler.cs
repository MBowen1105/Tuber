using AutoMapper;
using MediatR;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetById
{
    public class ImportTemplateGetByIdQueryHandler : IRequestHandler<ImportTemplateGetByIdQueryRequest, ImportTemplateGetByIdQueryResponse>
    {
        private readonly IImportTemplateRetrievalService _importTemplateRetrieverService;
        private readonly IMapper _mapper;

        public ImportTemplateGetByIdQueryHandler(IImportTemplateRetrievalService importTemplateRetrieverService, IMapper mapper)
        {
            _importTemplateRetrieverService = importTemplateRetrieverService;
            _mapper = mapper;
        }

        public Task<ImportTemplateGetByIdQueryResponse> Handle(ImportTemplateGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _importTemplateRetrieverService.GetById(request.ImportTemplateId);

            var response = _mapper.Map<ImportTemplate, ImportTemplateGetByIdQueryResponse>(serviceResult.Payload);
         
            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
