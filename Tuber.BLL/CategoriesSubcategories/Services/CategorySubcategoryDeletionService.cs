using Tuber.Application.Common.Interfaces;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.CategoriesSubcategories.Services;
public class CategorySubcategoryDeletionService : ICategorySubcategoryDeletionService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepo;

    public CategorySubcategoryDeletionService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepo = categorySubcategoryRepo;
    }

    public ServiceResult<int> Delete(Guid categorySubcategoryId)
    {
        var deletedCount = _categorySubcategoryRepo.Delete(categorySubcategoryId);

        if (deletedCount == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Delete, CategorySubcategory.FriendlyName, categorySubcategoryId));

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<int>(deletedCount);
    }
}
