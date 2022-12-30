using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ICategorySubcategoryRepository : IRepository<CategorySubcategory>
{
    //  Repository Commands
    CategorySubcategory Add(CategorySubcategory categorySubcategory);
    int Delete(Guid categorySubcategoryId);

    //  Repository Queries
    CategorySubcategory GetById(Guid categorySubcategoryId);
    string? Exists(Guid categoryId, Guid subcategoryId);
}