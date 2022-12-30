using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

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
        var categorySubcategoryModel = _categorySubcategoryRepo.GetById(categorySubcategoryId);

        if (categorySubcategoryModel.CategorySubcategoryId == Guid.Empty)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new EntityDoesNotExistException(Category.FriendlyName, categorySubcategoryId));

        if (categorySubcategoryModel.IsCoreCategorySubcategory)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new CannotDeleteCoreEntityException(CategorySubcategory.FriendlyName, categorySubcategoryId));

        var categorySubcategory = _categorySubcategoryRepo.Delete(categorySubcategoryId);

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<int>(payload: 1);
    }
}
