using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.Common.Interfaces.FileSystem;

namespace Tuber.FileSystem;
public static class DependencyInjection
{    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<IFileSystem, FileSystem>();

        return services;
    }
}
