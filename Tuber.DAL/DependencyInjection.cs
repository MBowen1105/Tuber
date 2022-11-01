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

        var cs = "server=(localDb)\\\\MSSQLLocalDb;database=TuberDb;Trusted_Connection=true;";

        services.AddDbContextPool<ApplicationDbContext>(options =>
             options.UseSqlServer(cs));

        services.AddSingleton<IBankRepo, BankRepo>();

        return services;
    }
}
