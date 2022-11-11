namespace Tuber.Domain.Models;
public class AuditableEntity
{
    public Guid CreatedByUserId { get; set; }
    public Guid? UpdatedByUserId { get; set; }
    public bool IsArchived { get; set; }
}
