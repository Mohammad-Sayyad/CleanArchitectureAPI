﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SOLID.CleanArchitecture_.NET.Application
{
    public static class ApplicationServiceRegistration
    {

        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
