using Tuber.Application.Models;

namespace Tuber.Application.Common;
public class AuditableEntity
{
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public Guid? UpdatedByUserId { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
    virtual public User? CreatedByUser { get; set; }
    virtual public User? UpdatedByUser { get; set; }
}
