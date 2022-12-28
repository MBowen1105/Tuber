using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Categories.Services;
public class CategorySubcategoryRetrievalService : ICategorySubcategoryRetrievalService
{
    public (Guid? categoryId, Guid? subcategoryId) SuggestCategorisation(string? dateISO8601, string? description, string? reference, string? moneyIn, string? moneyOut)
    {
        return (null, null);
    }
}
