namespace Tuber.Domain.Dtos;
public class GetCategoriesPaged_Category
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public bool IsCoreCategory { get; init; } = false;
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; }
    public DateTime UpdatedOnUtc { get; init; }
}
