namespace Tuber.BLL.Categories.Commands.UpdateCategory;
public class UpdateCategoryAPIRequest
{
    public Guid CategoryId { get; set; }

    public string CategoryName { get; set; } = "";
}
