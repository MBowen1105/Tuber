using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryRetrievalService
{
    ServiceResult<CategorySubcategory> GetById(Guid categorySubcategoryId);
    (Guid? categoryId, Guid? subcategoryId) SuggestCategorisation(
        string? dateISO8601,
        string? description,
        string? reference,
        string? moneyIn,
        string? moneyOut);
}
