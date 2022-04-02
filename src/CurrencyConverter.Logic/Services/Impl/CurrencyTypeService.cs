using AutoMapper;
using CurrencyConverter.Data.Repositories;
using CurrencyConverter.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverter.Logic.Services.Impl
{
    public class CurrencyTypeService : ICurrencyTypeService
    {
        private readonly ICurrencyTypeRepository currencyTypeRepository;
        private readonly IMapper mapper;

        public CurrencyTypeService(ICurrencyTypeRepository currencyTypeRepository, IMapper mapper)
        {
            this.currencyTypeRepository = currencyTypeRepository;
            this.mapper = mapper;
        }

        public async Task<List<CurrencyType>> GetCurrencyTypes(CancellationToken cancellationtoken)
        {
            return this.mapper.Map<List<CurrencyType>>(await this.currencyTypeRepository.GetAllAsync(cancellationtoken));
        }
    }
}
