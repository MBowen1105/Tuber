using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.Imports;
public class ImportRepository : IImportRepository
{
    private readonly ApplicationDbContext _context;

    public ImportRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Import Add(Import import)
    {
        _context.Imports.Add(import);

        return import;
    }

    public void Clear(Guid bankAccountId)
    {
        var existingRows = _context.Imports
            .Where(x => x.BankAccountId == bankAccountId);

        _context.Imports.RemoveRange(existingRows);
    }


    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion

    #region "Queries"
    public List<Import> GetByBankAccountId(Guid bankAccountId)
    {
        return _context.Imports
            .Include(x => x.ImportedByUser)
            .Where(x => x.BankAccountId == bankAccountId)
            .OrderBy(x => x.DateValue)
            .ThenBy(x => x.ImportRowNumber)
            .ToList();
    }

    #endregion
}
