using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.Application.Imports.Services;
public class ImportRetrievalService : IImportRetrievalService
{
    private readonly IImportRepository _importRepo;

    public ImportRetrievalService(IImportRepository importRepo)
    {
        _importRepo = importRepo;
    }
    public ServiceResult<List<Import>> GetByBankAccountId(Guid bankAccountId)
    {
        var importList = _importRepo.GetByBankAccountId(bankAccountId);
        
        return new ServiceResult<List<Import>>(importList);
    }
}
