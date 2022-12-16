using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.Categories;
public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Category Add(Category category)
    {
        try
        {
            _context.Categories.Add(category);
        }
        catch (Exception)
        {
            category = new Category();
        }
        return category;
    }

    public Category Update(Category category)
    {
        var categoryModel = _context.Categories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.CategoryId == category.CategoryId && x.IsDeleted == false);

        if (categoryModel is null)
            return new Category();

        categoryModel.CategoryName = category.CategoryName;

        return categoryModel;
    }

    public int Delete(Guid id)
    {
        var category = _context.Categories
            .FirstOrDefault(x => x.CategoryId == id && x.IsDeleted == false);

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

    #region "Queries"
    public Category GetById(Guid id)
    {
        var category = _context.Categories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.CategoryId == id && x.IsDeleted == false);

        return category ?? new Category();
    }

    public List<Category> GetPaged(int pageNumber, int pageSize)
    {
        var l = _context.Categories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
        return l;
    }

    public bool Exists(string categoryName)
    {
        return _context.Categories.Any(x => x.CategoryName == categoryName);
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Categories
            .Count(x => x.IsDeleted == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    #endregion
}
