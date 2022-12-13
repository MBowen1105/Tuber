using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetPaged;
public class ImportTemplateGetPagedAPIResponse : PagedAPIResponse
{
    public int ImportTemplateCount { get; init; }
    public List<ImportTemplateGetPaged_ImportTemplate> ImportTemplates { get; init; } = new();
}
