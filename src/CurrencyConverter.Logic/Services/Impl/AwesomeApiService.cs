using CurrencyConverter.Logic.HttpHandlers.Factories;
using CurrencyConverter.Logic.Infrastructure;
using CurrencyConverter.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.Services.Impl
{
    public class AwesomeApiService : IAwesomeApiService
    {
        private readonly AwesomeApiSettings apiSettings;
        private readonly IBaseHttpHandlerFactory httpHandlerFactory;

        public AwesomeApiService(AwesomeApiSettings apiSettings, IBaseHttpHandlerFactory httpHandlerFactory)
        {
            this.apiSettings = apiSettings;
            this.httpHandlerFactory = httpHandlerFactory;
        }

        public async Task<Currency> GetLastAsync(Tuple<string, string> currencyTuple, CancellationToken cancellationToken)
        {
            if (currencyTuple is null)
            {
                throw new ArgumentNullException(nameof(currencyTuple));
            }

            var httpHandler = this.httpHandlerFactory.Create(this.apiSettings.ClientName);

            var uri = this.BuildGetUri(currencyTuple);

            var result = await httpHandler.HttpGetAsync<Dictionary<object, Currency>>(uri, cancellationToken);
            return result.Values.FirstOrDefault();
        }

        private string BuildGetUri(Tuple<string, string> currencyTuple)
        {
            // example: https://economia.awesomeapi.com.br/last/USD-BRL
            var url = new StringBuilder($"{this.apiSettings.BaseUrl}last/");
            url.Append($"{currencyTuple.Item1}")
               .Append('-')
               .Append($"{currencyTuple.Item2}");

            return url.ToString();
        }
    }
}
