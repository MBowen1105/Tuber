﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tuber.Domain.Interfaces.Infrastructure.DateTimes;

namespace Tuber.SystemClock;
public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<IDateTimeService, DateTimeService>();

        return services;
    }
}