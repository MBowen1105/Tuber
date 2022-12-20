using MediatR;

namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetById;
public class ImportTemplateGetByIdQueryRequest : IRequest<ImportTemplateGetByIdQueryResponse>
{
    public Guid ImportTemplateId { get; set; }
}
