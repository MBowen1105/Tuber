using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.DAL.Repositories;
using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.DAL;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services,
        IConfiguration config)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var cs = config.GetConnectionString("ApplicationDbConnection");

        services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(cs,
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<IBankRepository, BankRepository>();

        return services;
    }
}
