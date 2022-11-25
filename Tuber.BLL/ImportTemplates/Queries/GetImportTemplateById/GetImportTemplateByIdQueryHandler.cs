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

            var response = _mapper.Map<ServiceResult<ImportTemplate>, GetImportTemplateByIdQueryResponse>(serviceResult);
            //var response = new GetImportTemplateByIdQueryResponse
            //{
            //    ImportTemplateId = serviceResult.Payload.ImportTemplateId,
            //    TemplateName = serviceResult.Payload.TemplateName,
            //    ImportFileName = serviceResult.Payload.ImportFileName,
            //    ExpectedHeaderRowCount = serviceResult.Payload.ExpectedHeaderRowCount,
            //    ExpectedColumnCount = serviceResult.Payload.ExpectedColumnCount,
            //    SeperatorChar = serviceResult.Payload.SeperatorChar,
            //    DateColumnNumber = serviceResult.Payload.DateColumnNumber,
            //    DescriptionOnStatementColumnNumber = serviceResult.Payload.DescriptionOnStatementColumnNumber,
            //    TransactionTypeColumnNumber = serviceResult.Payload.TransactionTypeColumnNumber,
            //    MoneyInColumnNumber = serviceResult.Payload.MoneyInColumnNumber,
            //    MoneyOutColumnNumber = serviceResult.Payload.MoneyOutColumnNumber,
            //    BalanceOnStatementColumnNumber = serviceResult.Payload.BalanceOnStatementColumnNumber,
            //    SortCodeColumnNumber = serviceResult.Payload.SortCodeColumnNumber,
            //    AccountNumberColumnNumber = serviceResult.Payload.AccountNumberColumnNumber,
            //    Exceptions = serviceResult.Exceptions.ToList()
            //};

            return Task.FromResult(response);
        }
    }
}
