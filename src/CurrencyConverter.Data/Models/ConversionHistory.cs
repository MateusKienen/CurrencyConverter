using System;

namespace CurrencyConverter.Data.Models
{
    public class ConversionHistory : BaseEntity
    {        
        public DateTime RequestedAt { get; set; }
    }
}
