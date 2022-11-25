using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.Interfaces.FileSystem;
using Tuber.Infrastructure.FileSystem;

namespace Tuber.FileSystem;
public static class DependencyInjection
{    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<IFileSystemRetrievalService, FileSystemRetrievalService>();

        return services;
    }
}
