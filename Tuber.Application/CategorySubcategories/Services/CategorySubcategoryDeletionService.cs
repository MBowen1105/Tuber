using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.CategorySubcategories.Services;
public class CategorySubcategoryDeletionService : ICategorySubcategoryDeletionService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepo;

    public CategorySubcategoryDeletionService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepo = categorySubcategoryRepo;
    }

    public ServiceResult<int> Delete(Guid categorySubcategoryId)
    {
        var categorySubcategory = _categorySubcategoryRepo.Delete(categorySubcategoryId);

        if (categorySubcategory == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(CategorySubcategory.FriendlyName, categorySubcategoryId));

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<int>(payload: 0);
    }
}
