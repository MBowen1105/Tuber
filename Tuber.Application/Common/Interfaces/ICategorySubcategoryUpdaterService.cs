using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryUpdaterService
{
    ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid subcategoryId);
   
}
