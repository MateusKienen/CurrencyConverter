using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.HttpHandlers.Factories.Impl
{
    public class BaseHttpHandlerFactory : IBaseHttpHandlerFactory
    {
        private readonly IHttpClientFactory httpClientFactory;

        public BaseHttpHandlerFactory(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public BaseHttpHandler Create(string httpClientName)
        {
            return new BaseHttpHandler(this.httpClientFactory.CreateClient(httpClientName));
        }
    }
}
