using AutoMapper;
using FluentValidation;
using MediatR;
using System.Reflection;

namespace Tuber.API;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly(); 

        services.AddMediatR(assembly)
            .AddAutoMapper(assembly);

        services.AddValidatorsFromAssembly(assembly);

        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(assembly);
        });

        config.AssertConfigurationIsValid();

        return services;
    }
}
