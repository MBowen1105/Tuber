using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface ICategorySubcategoryRepository : IRepository<CategorySubcategory>
{
    //  Repository Commands
    CategorySubcategory Add(CategorySubcategory categorySubcategory);
    
    int Delete(Guid categorySubcategoryId);
}
