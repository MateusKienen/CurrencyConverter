using CurrencyConverter.Logic.Models;
using CurrencyConverter.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAwesomeApiService awesomeApiService;
        private readonly ICurrencyTypeService currencyTypeService;

        [BindProperty]
        public Currency Currency { get; set; }
        
        [BindProperty]
        public List<CurrencyType> CurrencyTypes  { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IAwesomeApiService awesomeApiService, ICurrencyTypeService currencyTypeService)
        {
            _logger = logger;
            this.awesomeApiService = awesomeApiService;
            this.currencyTypeService = currencyTypeService;
        }

        public async Task OnGet(CancellationToken cancellation)
        {
            this.CurrencyTypes = await this.currencyTypeService.GetCurrencyTypes(cancellation);
            this.Currency = await this.awesomeApiService.GetLastAsync(new Tuple<string, string>("USD", "BRL"), cancellation);
        }
    }
}
