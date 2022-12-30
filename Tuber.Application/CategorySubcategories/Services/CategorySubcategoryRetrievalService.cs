using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.CategorySubcategories.Services;
public class CategorySubcategoryRetrievalService : ICategorySubcategoryRetrievalService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepository;

    public CategorySubcategoryRetrievalService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepository = categorySubcategoryRepo;
    }

    public ServiceResult<CategorySubcategory> GetById(Guid categorySubcategoryId)
    {
        var categorySubcategory = _categorySubcategoryRepository.GetById(categorySubcategoryId);

        if (categorySubcategory.CategorySubcategoryId == Guid.Empty)
            return new ServiceResult<CategorySubcategory>(
                payload: categorySubcategory,
                exception: new EntityDoesNotExistException(CategorySubcategory.FriendlyName, categorySubcategoryId));

        return new ServiceResult<CategorySubcategory>(categorySubcategory);
    }
}
