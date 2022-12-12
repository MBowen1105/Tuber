using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.DAL.BankAccounts;
using Tuber.DAL.Banks;
using Tuber.DAL.Categories;
using Tuber.DAL.Imports;
using Tuber.DAL.Subcategories;
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
       
        services.AddScoped<IBankRepository, BankRepository>();
        services.AddScoped<IBankAccountRepository, BankAccountRepository>();
        services.AddScoped<IImportTemplateRepository, ImportTemplateRepository>();
        services.AddScoped<IImportRepository, ImportRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();

        return services;
    }
}
