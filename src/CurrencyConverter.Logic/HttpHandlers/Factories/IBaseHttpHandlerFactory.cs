using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.HttpHandlers.Factories
{
    public interface IBaseHttpHandlerFactory
    {
        BaseHttpHandler Create(string httpClientName);
    }
}
