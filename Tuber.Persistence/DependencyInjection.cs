﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Persistence.BankAccounts;
using Tuber.Persistence.Banks;
using Tuber.Persistence.Categories;
using Tuber.Persistence.CategorySubcategories;
using Tuber.Persistence.Imports;
using Tuber.Persistence.Subcategories;

namespace Tuber.Persistence;
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
        services.AddScoped<ICategorySubcategoryRepository, CategorySubcategoryRepository>();

        return services;
    }
}