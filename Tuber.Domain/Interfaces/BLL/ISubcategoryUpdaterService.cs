using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ISubcategoryUpdaterService
{
    Subcategory Add(string subcategoryName);
    Subcategory Update(Guid subcategoryId, string subcategoryName);
    int Delete(Guid subcategoryId);
}
