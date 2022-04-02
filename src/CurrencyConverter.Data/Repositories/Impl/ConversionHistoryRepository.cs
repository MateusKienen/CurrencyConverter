using CurrencyConverter.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Data.Repositories.Impl
{
    public class ConversionHistoryRepository : IConversionHistoryRepository
    {
        private readonly CurrencyConverterDbContext dbContext;

        public ConversionHistoryRepository(CurrencyConverterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ConversionHistory> CreateAsync(ConversionHistory conversionHistory, CancellationToken cancellationToken)
        {
            var result = await this.dbContext.ConversionHistories.AddAsync(conversionHistory, cancellationToken);
            return result.Entity;
        }

        public async Task<List<ConversionHistory>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await this.dbContext.ConversionHistories.ToListAsync();
        }

        public async Task<ConversionHistory> GetAsync(long id, CancellationToken cancellationToken)
        {
            return await this.dbContext.ConversionHistories.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
