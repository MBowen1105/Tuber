using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.AppConfigs;
public class AppConfigRepository : IAppConfigRepository
{
    private readonly ApplicationDbContext _context;

    public AppConfigRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
 

    public AppConfig Update(AppConfig appConfig)
    {
        var AppConfigModel = _context.AppConfigs
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault();

        if (AppConfigModel is null)
            return new AppConfig();

        AppConfigModel.CategorySuggestionHorizonDays = appConfig.CategorySuggestionHorizonDays;

        return AppConfigModel;
    }

    #endregion

    #region "Queries"
    public AppConfig Get()
    {
        var AppConfig = _context.AppConfigs
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault();

        return AppConfig ?? new AppConfig();
    }

    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
