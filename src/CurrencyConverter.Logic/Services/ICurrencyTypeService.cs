using CurrencyConverter.Logic.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.Services
{
    public interface ICurrencyTypeService
    {
        Task<List<CurrencyType>> GetCurrencyTypes(CancellationToken cancellationtoken);
    }
}
