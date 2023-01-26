using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IImportRetrievalService
{
    ServiceResult<List<Import>> GetByInstitutionAccountId(Guid bankAccountId);
}
