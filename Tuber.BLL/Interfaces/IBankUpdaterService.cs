using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface IBankUpdaterService
{
    ServiceResult<Bank> Add(string name, int orderBy);
    ServiceResult<Bank> Update(Guid bankId, string name, int orderBy);
}
