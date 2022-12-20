using Tuber.Domain.Common;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IImportRetrievalService
{
    ServiceResult<List<Import>> GetByBankAccountId(Guid bankAccountId);
}
