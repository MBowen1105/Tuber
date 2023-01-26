using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.InstitutionAccounts;
public class InstitutionAccountRepository : Repository<InstitutionAccount>, IInstitutionAccountRepository
{
    public InstitutionAccountRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    #region "Commands"
    public InstitutionAccount Add(InstitutionAccount bankAccount)
    {
        throw new NotImplementedException();
    }

    public InstitutionAccount Update(InstitutionAccount bankAccount)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region "Queries"
    public InstitutionAccount GetById(Guid bankAccountId)
    {
        var bankAccount = _context.Set<InstitutionAccount>()
            .Include(x => x.Institution)
            .Include(x => x.ImportTemplate)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.InstitutionAccountId == bankAccountId && x.IsDeleted == false);

        return bankAccount ?? new InstitutionAccount();
    }

    public List<InstitutionAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<InstitutionAccount>()
            .Include(x => x.Institution)
            .Include(x => x.ImportTemplate)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<InstitutionAccount>()
            .Count(x => x.IsDeleted == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }


    #endregion

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
