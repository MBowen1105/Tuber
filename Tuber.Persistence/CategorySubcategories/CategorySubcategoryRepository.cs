using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Models;

namespace Tuber.Persistence.CategorySubcategories;
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
        var categorySubcategory = _context.CategorySubcategories
            .FirstOrDefault(x => x.CategorySubcategoryId == categorySubcategoryId &&
                x.IsDeleted == false);

        if (categorySubcategory == null)
            return 0;

        categorySubcategory.IsDeleted = true;

        return 1;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion

    #region "Queries"
    public CategorySubcategory GetById(Guid categorySubcategoryId)
    {
        var categorySubcategory = _context.CategorySubcategories
            .FirstOrDefault(x => x.CategorySubcategoryId == categorySubcategoryId && x.IsDeleted == false);

        return categorySubcategory ?? new CategorySubcategory();
    }

    public string? Exists(Guid categoryId, Guid subcategoryId)
    {
        var categorySubcategory = _context.CategorySubcategories
            .Include(x => x.Category)
            .Include(x => x.Subcategory)
            .FirstOrDefault(x => x.CategoryId == categoryId &&
                x.SubcategoryId == subcategoryId &&
                x.IsDeleted == false);
        if (categorySubcategory != null )
            return categorySubcategory.ShortName;
        return null;
    }
    #endregion
}
