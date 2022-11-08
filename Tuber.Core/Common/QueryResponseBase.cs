namespace Tuber.Core.Common;
public abstract class QueryResponseBase
{
    public List<Exception> Exceptions { get; set; } = new();
    public bool HasExceptions => Exceptions.Count > 0;
}
