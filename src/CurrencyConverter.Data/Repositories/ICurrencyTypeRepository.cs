using CurrencyConverter.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Data.Repositories
{
    public interface ICurrencyTypeRepository
    {        
        Task<List<CurrencyType>> GetAllAsync(CancellationToken cancellationToken);
        
        Task<CurrencyType> GetAsync(long id, CancellationToken cancellationToken);
        
        Task<CurrencyType> GetAsync(string name, CancellationToken cancellationToken);
    }
}
