using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Categories.Services;
public class CategoryUpdaterService : ICategoryUpdaterService
{
    private readonly ICategoryRepository _categoryRepo;

    public CategoryUpdaterService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public ServiceResult<Category> Add(string categoryName)
    {
        var category = new Category
        {
            CategoryName = categoryName,
        };

        category = _categoryRepo.Add(category);

        if (category.CategoryId == Guid.Empty)
            return new ServiceResult<Category>(
               payload: category,
               exception: new EntityAlreadyExistsException(
                   entityName: "Category",
                   columnName: "Name", 
                   key: category.CategoryName));

        _categoryRepo.SaveChanges();

        return new ServiceResult<Category>(payload: category);
    }

    public ServiceResult<Category> Update(Guid id, string categoryName)
    {
        var category = new Category
        {
            CategoryId = id,
            CategoryName = categoryName
        };

        category = _categoryRepo.Update(category);

        _categoryRepo.SaveChanges();

        return new ServiceResult<Category>(category);
    }
}
