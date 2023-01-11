using Tuber.Domain.Models;

namespace Tuber.Application.Common;
public class AuditableEntity
{
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public Guid? UpdatedByUserId { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
    public virtual User? CreatedByUser { get; set; }
    public virtual User? UpdatedByUser { get; set; }
}
