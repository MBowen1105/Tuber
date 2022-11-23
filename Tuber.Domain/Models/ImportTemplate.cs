using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class ImportTemplate : AuditableEntity
{
    public Guid ImportTemplateId { get; set; }
    public string TemplateName { get; set; } = "";
    public bool IsDeleted { get; set; }
}
