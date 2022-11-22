using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.DAL.BankAccounts;
using Tuber.DAL.Banks;
using Tuber.Domain.Interfaces.DAL;

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

        services.AddMvc().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler= System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        });

        services.AddScoped<IBankRepository, BankRepository>();
        services.AddScoped<IBankAccountRepository, BankAccountRepository>();

        return services;
    }
}
