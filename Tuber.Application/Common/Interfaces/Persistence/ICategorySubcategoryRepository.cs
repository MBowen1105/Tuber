using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ICategorySubcategoryRepository : IRepository<CategorySubcategory>
{
    //  Repository Commands
    CategorySubcategory Add(CategorySubcategory bank);
    int Delete(Guid categorySubcategoryId);

    //  Repository Queries
    CategorySubcategory GetById(Guid bankId);
    string? Exists(Guid categoryId, Guid subcategoryId);
}