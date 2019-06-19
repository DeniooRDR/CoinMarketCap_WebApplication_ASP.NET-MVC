using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoinMarketCap.Models
{
    public class CurrencyContext : DbContext
    {
        public DbSet<CurrencyModel> CurrencyModels { get; set; }
    }
}