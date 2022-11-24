using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IImportRepository : IRepository<Import>
{
    //  Repository Commands
    Import Add(Import import);

    //  Repository Queries
  
}
