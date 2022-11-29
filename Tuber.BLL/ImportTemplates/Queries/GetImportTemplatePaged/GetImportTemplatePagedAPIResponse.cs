using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged;
public class GetImportTemplatePagedAPIResponse : PagedAPIResponse
{
    public int ImportTemplateCount { get; init; }
    public List<ImportTemplateDto> ImportTemplates { get; init; } = new();
}
