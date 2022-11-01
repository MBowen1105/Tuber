namespace Tuber.Core.Common;
public abstract class PagedQueryResponseBase : QueryResponseBase
{
    public int TotalPages { get; init; }
}
