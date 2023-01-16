using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IAppConfigRepository : IRepository<AppConfig>
{
    //  Repository Commands
    AppConfig Update(int categorySuggestionHorizonDays);

    //  Repository Queries
    AppConfig Get();
}
