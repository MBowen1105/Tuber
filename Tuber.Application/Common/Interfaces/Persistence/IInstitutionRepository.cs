using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IInstitutionRepository : IRepository<Institution>
{
    //  Repository Commands
    Institution Add(Institution institution);
    Institution Update(Institution institution);
    int Delete(Guid institutionId);

    //  Repository Queries
    Institution GetById(Guid institutionId);
    List<Institution> GetPaged(int pageNumber, int pageSize);
    bool NameExists(string institutionName);
    int CountPages(int pageSize);
}
