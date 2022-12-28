using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ISubcategoryRepository : IRepository<Subcategory>
{
    //  Repository Commands
    Subcategory Add(Subcategory subcategory);
    Subcategory Update(Subcategory subcategory);
    int Delete(Guid subcategoryId);

    //  Repository Queries
    Subcategory GetById(Guid subcategoryId);
    List<Subcategory> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
