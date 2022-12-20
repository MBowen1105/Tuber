using Microsoft.Extensions.DependencyInjection;
using Tuber.Application.Common.Interfaces;

namespace Tuber.SystemClock;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<ISystemClock, SystemClock>();

        return services;
    }
}
