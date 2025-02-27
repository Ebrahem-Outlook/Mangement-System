﻿using Application.Core.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.AddOpenBehavior < typeof(LoggingBehavior<,>) >
        });

        return services;
    }
}
