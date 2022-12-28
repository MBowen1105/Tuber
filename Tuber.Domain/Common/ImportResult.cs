namespace Tuber.Application.Common;
public class ImportResult
{
    public int TotalRowCount { get; set; } = 0;
    public int ValidRowCount { get; set; } = 0;
    public int InvalidRowCount { get; set; } = 0;
}
