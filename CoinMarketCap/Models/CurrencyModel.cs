﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinMarketCap.Models
{
    public class CurrencyModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string rank { get; set; }
        public string price_usd { get; set; }        
        public string volume_usd_24h { get; set; }
        public string market_cap_usd { get; set; }
        public string available_supply { get; set; }
        public string total_supply { get; set; }
        public string percent_change_1h { get; set; }
        public string percent_change_24h { get; set; }
        public string percent_change_7d { get; set; }
        //public DateTime RefreshTime { get; set; }
        public string last_updated { get; set; }

    }
}