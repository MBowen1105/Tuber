namespace Tuber.Core.Interfaces;
public interface IPagedAPIQuery
{
    int PageNumber { get; init; }
    int PageSize { get; init; }

}
