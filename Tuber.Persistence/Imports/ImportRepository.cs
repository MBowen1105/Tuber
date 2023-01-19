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

    public Import Update(Guid importId, Guid categoryId, Guid? subcategoryId, string? notes)
    {
        var import = _context.Imports
            .FirstOrDefault(x => x.ImportId == importId);

        if (import is null)
            return new Import();

        import.CategoryId = categoryId;
        import.SubcategoryId = subcategoryId;
        import.Notes = notes;

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
        var imports = _context.Imports
            .Include(x => x.BankAccount)
            .Include(x => x.Category)
            .Include(x => x.Subcategory)
            .Include(x => x.ImportedByUser)
            .Where(x => x.BankAccountId == bankAccountId)
            .OrderBy(x => x.DateValueISO8601)
            .ThenBy(x => x.ImportRowNumber);
        return imports.ToList();
    }

    #endregion
}
