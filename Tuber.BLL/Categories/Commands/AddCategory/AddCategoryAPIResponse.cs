namespace Tuber.BLL.Categories.Commands.AddCategory;
public class AddCategoryAPIResponse
{
    public Guid CategoryId { get; init; }
    public string CategoryName { get; set; } = "";
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
}
