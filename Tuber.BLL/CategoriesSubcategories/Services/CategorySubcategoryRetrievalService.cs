using Tuber.BLL.Interfaces;

namespace Tuber.BLL.Categories.Services;
public class CategorySubcategoryRetrievalService : ICategorySubcategoryRetrievalService
{
    public CategorySubcategoryRetrievalService()
    {

    }

    public (Guid? categoryId, Guid? subcategoryId) SuggestCategorisation(string? dateISO8601, string? description, string? reference, string? moneyIn, string? moneyOut)
    {
        return (null, null);
    }
}
