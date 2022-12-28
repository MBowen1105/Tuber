using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface ICategoryRepository : IRepository<Category>
{
    //  Repository Commands
    Category Add(Category category);
    Category Update(Category category);
    int Delete(Guid id);

    //  Repository Queries
    Category GetById(Guid id);
    List<Category> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
