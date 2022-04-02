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
    public class CurrencyTypeRepository : ICurrencyTypeRepository
    {
        private readonly CurrencyConverterDbContext dbContext;

        public CurrencyTypeRepository(CurrencyConverterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<CurrencyType>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await this.dbContext.CurrencyTypes.ToListAsync();
        }

        public async Task<CurrencyType> GetAsync(long id, CancellationToken cancellationToken)
        {
            return await this.dbContext.CurrencyTypes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<CurrencyType> GetAsync(string name, CancellationToken cancellationToken)
        {
            return await this.dbContext.CurrencyTypes.FirstOrDefaultAsync(c => c.Name == name);
        }
    }
}
