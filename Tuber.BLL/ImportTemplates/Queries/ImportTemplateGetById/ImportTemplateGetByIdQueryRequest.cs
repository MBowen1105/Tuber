using MediatR;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetById;
public class ImportTemplateGetByIdQueryRequest : IRequest<ImportTemplateGetByIdQueryResponse>
{
    public Guid ImportTemplateId { get; set; }
}
