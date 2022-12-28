using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.CategorySubcategories.Services;
public class CategorySubcategoryUpdaterService : ICategorySubcategoryUpdaterService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepo;

    public CategorySubcategoryUpdaterService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepo = categorySubcategoryRepo;
    }

    public ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid subcategoryId)
    {
        var shortName = _categorySubcategoryRepo.Exists(categoryId, subcategoryId);

        if (shortName != null)
            return new ServiceResult<CategorySubcategory>(
                payload: new CategorySubcategory(),
                exception: new EntityAlreadyExistsException(CategorySubcategory.FriendlyName, "Name", shortName));
        
        var categorySubcategory = new CategorySubcategory
        {
            CategoryId = categoryId,
            SubcategoryId = subcategoryId
        };

        categorySubcategory = _categorySubcategoryRepo.Add(categorySubcategory);

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<CategorySubcategory>(payload: categorySubcategory);
    }
}