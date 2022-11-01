using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddDbContextPool<ApplicationDbContext>(options => options.UseInMemoryDatabase("TuberDb"));

        services.AddSingleton<IBankRepo, BankRepo>();

        return services;
    }
}
