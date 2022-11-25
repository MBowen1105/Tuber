using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.Interfaces.Authorisation;

namespace Tuber.Authentication;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<ICurrentUserService, CurrentUserService>();

        return services;
    }
}
