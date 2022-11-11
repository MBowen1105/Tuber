using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.Interfaces.Infrastructure.Users;
using Tuber.Infrastructure.Users;

namespace Tuber.Users;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<ICurrentUserService, CurrentUserService>();

        return services;
    }
}
