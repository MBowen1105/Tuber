using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankUpdaterService
{
    Bank Add(string name, int orderBy);
    Bank Update(Guid id, string name, int orderBy);
    int Delete(Guid id);
}
