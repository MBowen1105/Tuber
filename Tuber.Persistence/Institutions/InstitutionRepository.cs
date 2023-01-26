using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Institutions;
public class InstitutionRepository : IInstitutionRepository
{
    private readonly ApplicationDbContext _context;

    public InstitutionRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Institution Add(Institution bank)
    {
        try
        {
            _context.Institutions.Add(bank);
        }
        catch (Exception)
        {
            //  Return a null Institution object
            bank = new Institution();
        }
        return bank;
    }

    public Institution Update(Institution bank)
    {
        var bankModel = _context.Institutions
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.InstitutionId == bank.InstitutionId && x.IsDeleted == false);

        if (bankModel is null)
            return new Institution();

        bankModel.InstitutionName = bank.InstitutionName;
        bankModel.OrderBy = bank.OrderBy;

        return bankModel;
    }

    public int Delete(Guid institutionId)
    {
        var institution = _context.Institutions
            .FirstOrDefault(x => x.InstitutionId == institutionId && x.IsDeleted == false);

        if (institution == null)
            return 0;

        institution.IsDeleted = true;

        //  Soft Delete all associated bank accounts
        foreach (var bankAccount in institution.InstitutionAccounts!)
        {
            bankAccount.IsDeleted = true;
        }

        return 1;
    }

    #endregion

    #region "Queries"
    public Institution GetById(Guid id)
    {
        var bank = _context.Institutions
            .Include(x => x.InstitutionAccounts)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.InstitutionId == id && x.IsDeleted == false);

        return bank ?? new Institution();
    }

    public List<Institution> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Institutions
            .Include(x => x.InstitutionAccounts)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .OrderBy(x => x.OrderBy)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Institutions
            .Count(x => x.IsDeleted == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    public bool NameExists(string bankName)
    {
        return _context.Institutions.Any(x => x.InstitutionName == bankName);
    }

    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
