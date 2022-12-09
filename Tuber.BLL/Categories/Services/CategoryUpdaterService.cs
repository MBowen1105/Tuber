using System.Xml.Linq;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories.Services;
public class CategoryUpdaterService : ICategoryUpdaterService
{
    private readonly ICategoryRepository _categoryRepo;

    public CategoryUpdaterService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public Category Add(string categoryName)
    {
        var categoryModel = _categoryRepo.Add(new Category
        {
            CategoryName = categoryName,
        });

        _categoryRepo.SaveChanges();

        categoryModel = _categoryRepo.GetById(categoryModel.CategoryId);

        return categoryModel;
    }

    public int Delete(Guid id)
    {
        var categoryModel = _categoryRepo.GetById(id);

        if (categoryModel.CategoryId == Guid.Empty)
            return 0;

        var result = _categoryRepo.Delete(id);

        _categoryRepo.SaveChanges();

        return result;
    }

    public Category Update(Guid id, string categoryName)
    {
        var categoryModel = _categoryRepo.Update(new Category
        {
            CategoryId = id,
            CategoryName = categoryName
        });

        _categoryRepo.SaveChanges();

        return categoryModel;
    }
}
