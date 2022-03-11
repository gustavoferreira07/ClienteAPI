using ClienteService.Business.Cliente;
using ClienteService.Business.Interface;
using ClienteService.Business.Interface.Business;
using ClienteService.Data;
using ClienteService.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.service.api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ClienteContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
           

            services.AddScoped<IClienteBusiness, ClienteBusiness>();

            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();


            return services;
        }
    }
}
