using Tuber.Core.ValueObjects;

namespace Tuber.Core.Common;
public abstract class PagedQueryResponseBase : QueryResponseBase
{
    public PositiveInt? TotalPages { get; init; }
}
