using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IImportRepository : IRepository<Import>
{
    //  Repository Commands
    Import Add(Import import);
    void Clear(Guid bankAccountId);

    //  Repository Queries
    List<Import> GetByBankAccountId(Guid bankAccountId);
  
}
