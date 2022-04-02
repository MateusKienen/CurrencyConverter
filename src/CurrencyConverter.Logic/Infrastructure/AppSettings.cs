using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.Infrastructure
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public AwesomeApiSettings AwesomeApiSettings { get; set; }
    }
}
