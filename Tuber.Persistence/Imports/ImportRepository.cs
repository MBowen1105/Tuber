using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Imports;
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

    public Import Update(Guid importId, Guid categorySubcategoryId, string? notes)
    {
        var import = _context.Imports
            .FirstOrDefault(x => x.ImportId == importId);

        if (import is null)
            return new Import();

        import.CategorySubcategoryId = categorySubcategoryId;
        import.Notes =notes;

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
            .Include(x => x.BankAccount)
            .Include(x => x.CategorySubcategory)
            .Include(x => x.CategorySubcategory.Category)
            .Include(x => x.CategorySubcategory.Subcategory)
            .Where(x => x.BankAccountId == bankAccountId)
            .OrderBy(x => x.DateValueISO8601)
            .ThenBy(x => x.ImportRowNumber)
            .ToList();
    }

    #endregion
}
