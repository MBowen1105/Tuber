using Tuber.Application.Dtos;
using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IImportRetrievalService
{
    ServiceResult<List<Import>> GetByBankAccountId(Guid bankAccountId);
}
