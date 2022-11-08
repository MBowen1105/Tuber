namespace Tuber.Domain.API.Common;
public abstract class PagedAPIRequest
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 5;
}
