using CurrencyConverter.Data.Repositories;
using CurrencyConverter.Data.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Data
{
    public static class ServicesExt
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, Action<DbContextOptionsBuilder> dbContextOptions)
        {
            services.AddDbContext<CurrencyConverterDbContext>(dbContextOptions);

            services.AddScoped<IConversionHistoryRepository>(s =>
                new ConversionHistoryRepository(s.GetRequiredService<CurrencyConverterDbContext>()));
            
            services.AddScoped<ICurrencyTypeRepository>(s =>
                new CurrencyTypeRepository(s.GetRequiredService<CurrencyConverterDbContext>()));

            return services;
        }
    }
}
