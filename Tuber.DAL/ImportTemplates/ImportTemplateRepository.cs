using Microsoft.EntityFrameworkCore;
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


    public List<ImportTemplate> GetPaged(int pageNumber, int pageSize)
    {
        return _context.ImportTemplates
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<ImportTemplate>()
            .Count(x => x.IsDeleted == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);

    }
    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
