using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

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
        var isValid = _categorySubcategoryRepo.IsValid(categoryId, subcategoryId);

        if (isValid)
            return new ServiceResult<CategorySubcategory>(
                payload: new CategorySubcategory(),
                exception: new EntityAlreadyExistsException(
                    CategorySubcategory.FriendlyName, "Key", $"{categoryId}/{subcategoryId}"));
        
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