using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface ICategorySubcategoryUpdaterService
{
    ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid? subcategoryId);
}
