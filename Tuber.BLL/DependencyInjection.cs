using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.BLL.BankAccounts.Services;
using Tuber.BLL.Banks.Services;
using Tuber.BLL.Categories.Services;
using Tuber.BLL.Imports.Services;
using Tuber.BLL.ImportTemplates.Services;
using Tuber.BLL.PipelineBehaviours;
using Tuber.BLL.Subcategories.Services;
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

        services.AddScoped<IBankAccountRetrievalService, BankAccountRetrievalService>();

        services.AddScoped<IBankRetrievalService, BankRetrievalService>();
        services.AddScoped<IBankUpdaterService, BankUpdaterService>();
        services.AddScoped<IBankDeletionService, BankDeletionService>();

        services.AddScoped<ICategoryRetrievalService, CategoryRetrievalService>();
        services.AddScoped<ICategoryUpdaterService, CategoryUpdaterService>();
        services.AddScoped<ICategoryDeletionService, CategoryDeletionService>();

        services.AddScoped<ICategorySubcategoryRetrievalService, CategorySubcategoryRetrievalService>();

        services.AddScoped<IImportRetrievalService, ImportRetrievalService>();
        services.AddScoped<IImportUpdaterService, ImportUpdaterService>();
        services.AddScoped<IImportValidationService, ImportValidationService>();

        services.AddScoped<IImportTemplateRetrievalService, ImportTemplateRetrievalService>();

        services.AddScoped<ISubcategoryRetrievalService, SubcategoryRetrievalService>();
        services.AddScoped<ISubcategoryUpdaterService, SubcategoryUpdaterService>();
        services.AddScoped<ISubcategoryDeletionService, SubcategoryDeletionService>();


        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(assembly);
        });

        config.AssertConfigurationIsValid();

        return services;
    }
}
