using CurrencyConverter.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.Services
{
    public interface IAwesomeApiService
    {
        Task<Currency> GetLastAsync(Tuple<string, string> currencyTuple, CancellationToken cancellationToken);

        // Task<List<Currency>> GetLastAsync(List<Tuple<string, string>> currencyTuples, CancellationToken cancellationToken);
    }
}
