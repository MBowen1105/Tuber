﻿using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Application.BankAccounts.Services;
using Tuber.Application.Banks.Services;
using Tuber.Application.Categories.Services;
using Tuber.Application.CategorySubcategories.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Imports.Services;
using Tuber.Application.ImportTemplates.Services;
using Tuber.Application.Ledgers.Services;
using Tuber.Application.PipelineBehaviours;
using Tuber.Application.Subcategories.Services;

namespace Tuber.Application;
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
        services.AddScoped<IBankAccountUpdaterService, BankAccountUpdaterService>();

        services.AddScoped<IBankRetrievalService, BankRetrievalService>();
        services.AddScoped<IBankUpdaterService, BankUpdaterService>();
        services.AddScoped<IBankDeletionService, BankDeletionService>();

        services.AddScoped<ICategoryRetrievalService, CategoryRetrievalService>();
        services.AddScoped<ICategoryUpdaterService, CategoryUpdaterService>();
        services.AddScoped<ICategoryDeletionService, CategoryDeletionService>();

        services.AddScoped<ICategorySubcategoryRetrievalService, CategorySubcategoryRetrievalService>();
        services.AddScoped<ICategorySubcategoryUpdaterService, CategorySubcategoryUpdaterService>();
        services.AddScoped<ICategorySubcategoryDeletionService, CategorySubcategoryDeletionService>();

        services.AddScoped<IImportRetrievalService, ImportRetrievalService>();
        services.AddScoped<IImportUpdaterService, ImportUpdaterService>();
        services.AddScoped<IImportValidationService, ImportValidationService>();

        services.AddScoped<IImportTemplateRetrievalService, ImportTemplateRetrievalService>();

        services.AddScoped<ISubcategoryRetrievalService, SubcategoryRetrievalService>();
        services.AddScoped<ISubcategoryUpdaterService, SubcategoryUpdaterService>();
        services.AddScoped<ISubcategoryDeletionService, SubcategoryDeletionService>();

        services.AddScoped<ILedgerRetrievalService, LedgerRetrievalService>();

        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(assembly);
        });

        config.AssertConfigurationIsValid();

        return services;
    }
}
