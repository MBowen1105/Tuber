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

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion

    #region "Queries"
   
    #endregion
}
