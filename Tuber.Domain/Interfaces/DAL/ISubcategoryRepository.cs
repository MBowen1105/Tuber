using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface ISubcategoryRepository : IRepository<Subcategory>
{
    //  Repository Commands
    Subcategory Add(Subcategory subcategory);
    Subcategory Update(Subcategory subcategory);
    int Delete(Guid subcategoryId);

    //  Repository Queries
    Subcategory GetById(Guid subcategoryId);
    List<Subcategory> GetPaged(int pageNumber, int pageSize);
    bool Exists(string subcategoryName);
    int CountPages(int pageSize);
}
