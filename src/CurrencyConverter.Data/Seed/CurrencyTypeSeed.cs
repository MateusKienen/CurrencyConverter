using CurrencyConverter.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Data.Seed
{
    public static class CurrencyTypeSeed
    {
        public static void SeedCurrencyType(ModelBuilder modelBuilder)
        {
            var types = new List<CurrencyType>();
            using (StreamReader r = new StreamReader("../CurrencyConverter.Data/Seed/Resources/currencytypes.json"))
            {
                string json = r.ReadToEnd();
                types = JsonConvert.DeserializeObject<List<CurrencyType>>(json);
            }

            modelBuilder.Entity<CurrencyType>().HasData(types);
        }
    }
}
