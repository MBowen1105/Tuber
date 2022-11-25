using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Services;
public class ImportRetrievalService : IImportRetrievalService
{
    public ServiceResult<List<Import>> GetByBankAccountId(Guid bankAccountId)
    {
        return new ServiceResult<List<Import>>(
            payload: new List<Import>());
    }
}
