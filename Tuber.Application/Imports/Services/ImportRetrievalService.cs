using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Application.Imports.Services;
public class ImportRetrievalService : IImportRetrievalService
{
    private readonly IImportRepository _importRepo;

    public ImportRetrievalService(IImportRepository importRepo)
    {
        _importRepo = importRepo;
    }

    public ServiceResult<List<Import>> GetByInstitutionAccountId(Guid bankAccountId)
    {
        var importList = _importRepo.GetByInstitutionAccountId(bankAccountId);
        
        return new ServiceResult<List<Import>>(importList);
    }
}
