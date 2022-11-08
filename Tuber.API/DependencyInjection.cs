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

        services.AddMediatR(assembly);

        services.AddAutoMapper(assembly);

        // There should be no Validators DEFINED in the API (They are in the BLL)
        //services.AddValidatorsFromAssembly(assembly);

        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(assembly);
        });

        config.AssertConfigurationIsValid();

        return services;
    }
}
