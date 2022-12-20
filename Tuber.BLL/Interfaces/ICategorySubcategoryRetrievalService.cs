namespace Tuber.BLL.Interfaces;
public interface ICategorySubcategoryRetrievalService
{
    (Guid? categoryId, Guid? subcategoryId) SuggestCategorisation(
        string? dateISO8601,
        string? description,
        string? reference,
        string? moneyIn,
        string? moneyOut);
}
