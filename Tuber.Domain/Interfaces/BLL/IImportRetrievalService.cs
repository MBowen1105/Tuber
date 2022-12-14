using Tuber.Domain.Common;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportRetrievalService
{
    ServiceResult<List<Import>> GetByBankAccountId(Guid bankAccountId);
}
