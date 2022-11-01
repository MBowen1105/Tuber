using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.Domains;

namespace Tuber.Domain.DAL;
public interface IRepo
{
    BankDomain[] Get(PositiveInt pageNumber, PositiveInt pageSize);
}
