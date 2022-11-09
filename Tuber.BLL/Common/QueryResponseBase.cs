namespace Tuber.BLL.Common;
public class QueryResponseBase
{
    public List<Exception> Exceptions { get; set; } = new();
    public bool HasExceptions => Exceptions.Count > 0;
}
