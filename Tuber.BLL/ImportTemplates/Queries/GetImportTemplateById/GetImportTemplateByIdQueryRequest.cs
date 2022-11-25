using MediatR;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;
public class GetImportTemplateByIdQueryRequest : IRequest<GetImportTemplateByIdQueryResponse>
{
    public Guid ImportTemplateId { get; set; }
}
