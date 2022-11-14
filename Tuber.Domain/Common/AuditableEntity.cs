namespace Tuber.Domain.Common;
public class AuditableEntity
{
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? UpdatedByUserId { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public bool IsArchived { get; set; }
}
