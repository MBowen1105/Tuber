using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IAppConfigRetrievalService
{
    ServiceResult<AppConfig> Get();
}
