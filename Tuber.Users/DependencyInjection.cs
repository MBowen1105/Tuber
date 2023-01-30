using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.Common.Interfaces.Authentication;

namespace Tuber.Authentication;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
