using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged;
public class GetImportTemplatePagedQueryRequest : PagedRequest, IRequest<GetImportTemplatePagedQueryResponse>
{
}
