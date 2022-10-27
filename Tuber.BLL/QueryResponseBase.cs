namespace Tuber.BLL;
public class QueryResponseBase
{
    public List<Exception> Exceptions { get; init; } = new();
    public bool HasExceptions => Exceptions.Count > 0;
}
