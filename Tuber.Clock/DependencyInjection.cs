using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.Common.Interfaces.Clock;

namespace Tuber.Clock;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<IClock, Clock>();

        return services;
    }
}
