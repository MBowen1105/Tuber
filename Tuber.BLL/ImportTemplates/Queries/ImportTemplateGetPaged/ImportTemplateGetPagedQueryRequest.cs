using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetPaged;
public class ImportTemplateGetPagedQueryRequest : PagedRequest, IRequest<ImportTemplateGetPagedQueryResponse>
{
}
