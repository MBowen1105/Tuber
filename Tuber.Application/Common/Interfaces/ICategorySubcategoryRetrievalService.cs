using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryRetrievalService
{
    ServiceResult<CategorySubcategory> GetById(Guid categorySubcategoryId);
    ServiceResult<bool> IsValid(Guid categoryId, Guid? subcategoryId);
}
