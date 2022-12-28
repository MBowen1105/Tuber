using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetPaged;
public class ImportTemplateGetPagedQueryRequest : PagedRequest, IRequest<ImportTemplateGetPagedQueryResponse>
{
}
