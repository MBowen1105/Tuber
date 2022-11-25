using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.Imports;
public class ImportTemplateRepository : IImportTemplateRepository
{
    private readonly ApplicationDbContext _context;

    public ImportTemplateRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public ImportTemplate Add(ImportTemplate importTemplate)
    {
        _context.ImportTemplates.Add(importTemplate);

        return importTemplate;
    }
    #endregion

    #region "Queries"
    public ImportTemplate GetById(Guid importTemplateId)
    {
        var importTemplate = _context.ImportTemplates
            .FirstOrDefault(x => x.ImportTemplateId == importTemplateId);

        return importTemplate ?? new ImportTemplate();
    }
    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
