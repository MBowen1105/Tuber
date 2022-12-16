using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface ICategoryRepository : IRepository<Category>
{
    //  Repository Commands
    Category Add(Category category);
    Category Update(Category category);
    int Delete(Guid id);

    //  Repository Queries
    Category GetById(Guid id);
    List<Category> GetPaged(int pageNumber, int pageSize);
    bool Exists(string categoryName);
    int CountPages(int pageSize);
}
