using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IAppConfigUpdaterService
{
    ServiceResult<AppConfig> Update(int categorySuggestionHorizonDays);
}
