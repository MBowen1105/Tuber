namespace Tuber.Core.Common;
public abstract class PagedQueryResponseBase : CommandQueryResponseBase
{
    public int TotalPages { get; init; }
}
