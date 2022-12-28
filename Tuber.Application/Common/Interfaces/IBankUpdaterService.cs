using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IBankUpdaterService
{
    ServiceResult<Bank> Add(string bankAccountName, int orderBy);
    ServiceResult<Bank> Update(Guid bankId, string name, int orderBy);
}
