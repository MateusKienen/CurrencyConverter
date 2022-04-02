using CurrencyConverter.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Data.Repositories
{
    public interface IConversionHistoryRepository
    {
        Task<ConversionHistory> CreateAsync(ConversionHistory conversionHistory, CancellationToken cancellationToken);
        
        Task<List<ConversionHistory>> GetAllAsync(CancellationToken cancellationToken);
        
        Task<ConversionHistory> GetAsync(long id, CancellationToken cancellationToken);
    }
}
