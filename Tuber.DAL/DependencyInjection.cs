using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        
        services.AddSingleton<IBankRepo, BankRepo>();

        return services;
    }
}
