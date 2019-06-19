using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoinMarketCap.Models;
using Newtonsoft.Json;

namespace CoinMarketCap.Controllers
{
    public class CurrencyController : Controller
    {
        
        public ActionResult Index()
        {
            HttpWebRequest Ticker = (HttpWebRequest)WebRequest.Create(string.Format("https://api.coinmarketcap.com/v1/ticker/"));

            Ticker.Method = "Get";

            HttpWebResponse webResponse = (HttpWebResponse)Ticker.GetResponse();

            string currencyJson;
            using (Stream stream = webResponse.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                currencyJson = reader.ReadToEnd();
            }

            List<CurrencyModel> currencyModels = JsonConvert.DeserializeObject<List<CurrencyModel>>(currencyJson);
            ViewBag.curr = currencyModels;

            return View();
        }
    }
}