using CurrencyConverter.Data.Models;
using CurrencyConverter.Data.Seed;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CurrencyConverter.Data
{
    public class CurrencyConverterDbContext : DbContext
    {
        public CurrencyConverterDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ConversionHistory> ConversionHistories { get; set; }

        public DbSet<CurrencyType> CurrencyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CurrencyTypeSeed.SeedCurrencyType(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public void ApplyMigration()
        {
            if (this.Database.GetPendingMigrations().Any())
            {
                this.Database.Migrate();
            }
        }
    }
}
