using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.CategoriesSubcategories;
public class CategorySubcategoryRepository : ICategorySubcategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategorySubcategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public CategorySubcategory Add(CategorySubcategory categorySubcategory)
    {
        try
        {
            _context.CategorySubcategories.Add(categorySubcategory);
        }
        catch (Exception)
        {
            categorySubcategory = new CategorySubcategory();
        }
        return categorySubcategory;
    }

    public int Delete(Guid categorySubcategoryId)
    {
        var category = _context.CategorySubcategories
            .FirstOrDefault(x => x.CategorySubcategoryId == categorySubcategoryId && x.IsDeleted == false);

        if (category == null)
            return 0;

        category.IsDeleted = true;

        return 1;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion
}
