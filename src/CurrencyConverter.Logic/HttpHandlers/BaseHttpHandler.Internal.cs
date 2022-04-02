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
        private Uri CreateUri(string uri) => string.IsNullOrEmpty(uri) ? null : new Uri($"{this.HttpClient.BaseAddress}{uri}", UriKind.RelativeOrAbsolute);

        private async Task<HttpResponseMessage> InternalHttpGetAsync(string url, CancellationToken cancellationToken)
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = this.CreateUri(url),
            };

            var response = await this.HttpClient.SendAsync(requestMessage, cancellationToken);

            return response;
        }
    }
}