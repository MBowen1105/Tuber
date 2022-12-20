using Tuber.Domain.Common;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.CategoriesSubcategories.Services;
public class CategorySubcategoryUpdaterService : ICategorySubcategoryUpdaterService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepo;

    public CategorySubcategoryUpdaterService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepo = categorySubcategoryRepo;
    }

    public ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid? subcategoryId)
    {
        var categorySubcategory = new CategorySubcategory
        {
            CategoryId = categoryId,
            SubcategoryId = subcategoryId
        };

        categorySubcategory = _categorySubcategoryRepo.Add(categorySubcategory);

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<CategorySubcategory>(categorySubcategory);
    }
}
