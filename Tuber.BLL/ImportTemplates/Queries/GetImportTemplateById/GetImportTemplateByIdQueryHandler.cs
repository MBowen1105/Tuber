using AutoMapper;
using MediatR;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById
{
    public class GetImportTemplateByIdQueryHandler : IRequestHandler<GetImportTemplateByIdQueryRequest, GetImportTemplateByIdQueryResponse>
    {
        private readonly IImportTemplateRetrievalService _importTemplateRetrieverService;
        private readonly IMapper _mapper;

        public GetImportTemplateByIdQueryHandler(IImportTemplateRetrievalService importTemplateRetrieverService, IMapper mapper)
        {
            _importTemplateRetrieverService = importTemplateRetrieverService;
            _mapper = mapper;
        }

        public Task<GetImportTemplateByIdQueryResponse> Handle(GetImportTemplateByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _importTemplateRetrieverService.GetById(request.ImportTemplateId);

            var response = _mapper.Map<ImportTemplate, GetImportTemplateByIdQueryResponse>(serviceResult.Payload);
         
            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
