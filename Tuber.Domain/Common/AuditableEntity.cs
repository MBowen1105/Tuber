namespace Tuber.Domain.Common;
public class AuditableEntity
{
    public string CreatedByUserName { get; set; } = "";
    public DateTime CreatedOnUtc { get; set; }
    public string? UpdatedByUserName { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}
