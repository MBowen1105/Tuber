using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.InstitutionAccounts;
public class InstitutionAccountRepository : Repository<InstitutionAccount>, IInstitutionAccountRepository
{
    private readonly ApplicationDbContext _context;

    public InstitutionAccountRepository(ApplicationDbContext context)
           : base(context)
    {
        _context = context;
    }

    #region "Commands"
    public InstitutionAccount Add(InstitutionAccount institutionAccount)
    {
        throw new NotImplementedException();
    }

    public InstitutionAccount Update(InstitutionAccount institutionAccount)
    {
        var institutionAccountModel = _context.InstitutionAccounts
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.InstitutionAccountId == institutionAccount.InstitutionAccountId && x.IsDeleted == false);

        if (institutionAccountModel is null)
            return new InstitutionAccount();

        institutionAccountModel.InstitutionAccountName = institutionAccount.InstitutionAccountName;
        institutionAccountModel.OrderBy = institutionAccount.OrderBy;
        //institutionAccountModel.UKSortCode = institutionAccount.UKSortCode;
        //institutionAccountModel.UKInstitutionAccount = institutionAccount.UKInstitutionAccount;
        //institutionAccountModel.InstitutionId = institutionAccount.InstitutionId;
        //institutionAccountModel.ImportTemplateId = institutionAccount.ImportTemplateId;
        //institutionAccountModel.OpeningBalance = institutionAccount.OpeningBalance;

        return institutionAccountModel;
    }

    #endregion

    #region "Queries"
    public InstitutionAccount GetById(Guid institutionAccountId)
    {
        var institutionAccount = _context.Set<InstitutionAccount>()
            .Include(x => x.Institution)
            .Include(x => x.ImportTemplate)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.InstitutionAccountId == institutionAccountId && x.IsDeleted == false);

        return institutionAccount ?? new InstitutionAccount();
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
