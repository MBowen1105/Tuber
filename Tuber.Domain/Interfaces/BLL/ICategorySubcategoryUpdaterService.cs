using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ICategorySubcategoryUpdaterService
{
    ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid? subcategoryId);
}
