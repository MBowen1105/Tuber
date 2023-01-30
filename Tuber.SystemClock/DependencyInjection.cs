using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.Common.Interfaces.SystemClock;

namespace Tuber.SystemClock;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<ISystemClock, SystemClock>();

        return services;
    }
}
