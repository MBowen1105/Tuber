﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services,
        IConfiguration config)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var cs = config.GetConnectionString("ApplicationDbConnection");

        services.AddDbContextPool<ApplicationDbContext>(options =>
             options.UseSqlServer(cs));

        services.AddSingleton<IBankRepo, BankRepo>();

        return services;
    }
}
