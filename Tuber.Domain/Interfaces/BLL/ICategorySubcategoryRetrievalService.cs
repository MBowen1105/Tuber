namespace Tuber.Domain.Interfaces.BLL;
public interface ICategorySubcategoryRetrievalService
{
    (Guid? categoryId, Guid? subcategoryId) SuggestCategorisation(
        string? dateISO8601,
        string? description,
        string? reference,
        string? moneyIn,
        string? moneyOut);
}
