using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.BLL.BankAccounts.Services;
using Tuber.BLL.Banks.Services;
using Tuber.BLL.Imports.Services;
using Tuber.BLL.PipelineBehaviours;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddValidatorsFromAssembly(assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestLogger<,>));

        services.AddMediatR(assembly);

        services.AddAutoMapper(assembly);

        services.AddScoped<IBankUpdaterService, BankUpdaterService>();
        services.AddScoped<IBankRetrieverService, BankRetrieverService>();

        services.AddScoped<IBankAccountRetrieverService, BankAccountRetrieverService>();

        services.AddScoped<IImportUpdaterService, ImportUpdaterService>();
        
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(assembly);
        });

        config.AssertConfigurationIsValid();

        return services;
    }
}
