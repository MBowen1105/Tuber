using Tuber.Application.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetPaged;
public class ImportTemplateGetPagedAPIResponse : PagedAPIResponse
{
    public int ImportTemplateCount { get; init; }
    public List<ImportTemplateGetPaged_ImportTemplate> ImportTemplates { get; init; } = new();
}
