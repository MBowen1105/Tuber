namespace Tuber.Domain.Models;
public class ImportResult
{
    public Guid ImportId { get; set; }
    public int ValidRowCount { get; set; }
    public int InvalidRowCount { get; set; }
    public List<Exception> Exceptions { get; init; } = new List<Exception>();
}
