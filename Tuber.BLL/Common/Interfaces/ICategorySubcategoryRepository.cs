using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryRepository : IRepository<CategorySubcategory>
{
    //  Repository Commands
    CategorySubcategory Add(CategorySubcategory categorySubcategory);
    
    int Delete(Guid categorySubcategoryId);
}
