using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Categories.Services;
public class CategoryDeletionService : ICategoryDeletionService
{
    private readonly ICategoryRepository _categoryRepo;

    public CategoryDeletionService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }
   
    public ServiceResult<int> Delete(Guid categoryId)
    {
        var categoryModel = _categoryRepo.GetById(categoryId);

        if (categoryModel.CategoryId == Guid.Empty)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new EntityDoesNotExistException(Category.FriendlyName, categoryId));

        if (categoryModel.IsCoreCategory)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new CannotDeleteCoreEntityException(Category.FriendlyName, categoryId));

        var result = _categoryRepo.Delete(categoryId);

        _categoryRepo.SaveChanges();

        return new ServiceResult<int>(result);
    }
}
