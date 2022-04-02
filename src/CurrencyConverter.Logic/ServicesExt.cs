using CurrencyConverter.Data;
using CurrencyConverter.Logic.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

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

            return services;
        }
    }
}
