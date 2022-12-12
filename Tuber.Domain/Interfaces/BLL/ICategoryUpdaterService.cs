using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ICategoryUpdaterService
{
    Category Add(string categoryName);
    Category Update(Guid id, string categoryName);
    int Delete(Guid categoryId);
}
