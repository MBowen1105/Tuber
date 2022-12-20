using Tuber.Domain.Common;

namespace Tuber.BLL.CategoriesSubcategories.Services;
public interface ICategorySubcategoryDeletionService
{
    ServiceResult<int> Delete(Guid categorySubcategoryId);
}