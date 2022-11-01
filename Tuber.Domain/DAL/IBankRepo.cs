using Tuber.Domain.API.Banks.Domains;

namespace Tuber.Domain.DAL;
public interface IBankRepo
{
    List<BankDomain> Get(int pageNumber, int pageSize);
}
