using Tuber.Domain.Models;

namespace Tuber.Domain.Common;
public class AuditableEntity
{
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    virtual public User? CreatedByUser { get; set; }
    public string? UpdatedByUserName { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}
