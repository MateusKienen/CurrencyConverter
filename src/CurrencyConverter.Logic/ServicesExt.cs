using AutoMapper;
using CurrencyConverter.Data;
using CurrencyConverter.Data.Repositories;
using CurrencyConverter.Logic.HttpHandlers.Factories;
using CurrencyConverter.Logic.HttpHandlers.Factories.Impl;
using CurrencyConverter.Logic.Infrastructure;
using CurrencyConverter.Logic.Services;
using CurrencyConverter.Logic.Services.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace CurrencyConverter.Logic
{
    public static class ServicesExt
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDataServices(options =>
            {
                options.UseNpgsql(appSettings.ConnectionStrings.CurrencyConverterConnectionString);
            });

            // Services
            services.AddScoped<IAwesomeApiService>(s =>
                new AwesomeApiService(appSettings.AwesomeApiSettings, s.GetRequiredService<IBaseHttpHandlerFactory>()));
            
            services.AddScoped<ICurrencyTypeService>(s =>
                new CurrencyTypeService(s.GetRequiredService<ICurrencyTypeRepository>(), s.GetRequiredService<IMapper>()));

            // Mapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Http
            services.AddHttpClient(appSettings.AwesomeApiSettings.ClientName);

            services.AddScoped<IBaseHttpHandlerFactory>(s => new BaseHttpHandlerFactory(s.GetRequiredService<IHttpClientFactory>()));

            return services;
        }
    }
}
