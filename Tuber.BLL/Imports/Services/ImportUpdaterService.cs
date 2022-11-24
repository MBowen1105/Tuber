using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Services;
public class ImportUpdaterService : IImportUpdaterService
{
    private readonly IImportRepository _importRepo;

    public ImportUpdaterService(IImportRepository importRepo)
    {
        _importRepo = importRepo;
    }

    public ImportResult Import(Guid importTemplateId, Guid bankAccountId, string importFileName)
    {
        //  HACK: Remove
        return new ImportResult
        {
            ImportId = Guid.NewGuid(),
            ValidRowCount = 10,
            InvalidRowCount = 0,
            Exceptions = new List<Exception>()
        };
    }
}
