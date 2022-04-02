using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.HttpHandlers
{
    public partial class BaseHttpHandler
    {
        public BaseHttpHandler(HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        public HttpClient HttpClient { get; }

        public async Task<TResponse> HttpGetAsync<TResponse>(string url, CancellationToken cancellationToken)
        {
            var response = await this.InternalHttpGetAsync(url, cancellationToken);

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(result);
        }
    }
}
