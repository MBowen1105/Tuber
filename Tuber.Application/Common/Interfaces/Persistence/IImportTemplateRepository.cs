using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IImportTemplateRepository : IRepository<ImportTemplate>
{
    //  Repository Commands
    ImportTemplate Add(ImportTemplate importTemplate);

    //  Repository Queries
    ImportTemplate GetById(Guid importTemplateId);
    List<ImportTemplate> GetPaged(int pageNumber, int pageSize);

    int CountPages(int pageSize);

}
