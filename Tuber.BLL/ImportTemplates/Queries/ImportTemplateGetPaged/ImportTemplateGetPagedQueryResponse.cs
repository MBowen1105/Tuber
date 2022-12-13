using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetPaged;
public class GetImportTemplatePagedQueryResponse : PagedQueryResponseBase
{
    public int ImportTemplateCount { get; init; } = 0;
    public List<ImportTemplateGetPaged_ImportTemplate> ImportTemplates { get; init; } = new();
}
