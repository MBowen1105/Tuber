using Tuber.Core.ValueObjects;

namespace Tuber.Application.API.Common;
public abstract class PagedRequest
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 5;
}
