using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.DAL;
public interface IImportTemplateRepository : IRepository<ImportTemplate>
{
    //  Repository Commands
    ImportTemplate Add(ImportTemplate importTemplate);
    ImportTemplate GetById(Guid importTemplateId);

    //  Repository Queries

}
