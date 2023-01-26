using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IImportRepository : IRepository<Import>
{
    //  Repository Commands
    Import Add(Import import);

    Import Update(Guid importId, Guid categoryId, Guid? subcategoryId, string? notes);
    void Clear(Guid institutionAccountId);

    //  Repository Queries
    List<Import> GetByInstitutionAccountId(Guid institutionAccountId);
  
}
