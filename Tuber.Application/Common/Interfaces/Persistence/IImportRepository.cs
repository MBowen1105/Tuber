using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IImportRepository : IRepository<Import>
{
    //  Repository Commands
    Import Add(Import import);

    Import Update(Guid importId, Guid categoryId, Guid? subcategoryId, string? notes);
    void Clear(Guid bankAccountId);

    //  Repository Queries
    List<Import> GetByBankAccountId(Guid bankAccountId);
  
}
