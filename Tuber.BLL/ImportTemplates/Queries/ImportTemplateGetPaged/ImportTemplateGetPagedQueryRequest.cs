using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetPaged;
public class ImportTemplateGetPagedQueryRequest : PagedRequest, IRequest<ImportTemplateGetPagedQueryResponse>
{
}
