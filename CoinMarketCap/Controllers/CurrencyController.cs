using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using CoinMarketCap.Models;

namespace CoinMarketCap.Controllers
{
    public class CurrencyController : Controller
    {
        CurrencyContext db = new CurrencyContext();

        public ActionResult CurrencyShow()
        {
            HttpWebRequest Ticker = (HttpWebRequest)WebRequest.Create(string.Format("https://api.coinmarketcap.com/v1/ticker/"));

            Ticker.Method = "GET";

            HttpWebResponse WebResponse = (HttpWebResponse)Ticker.GetResponse();

            string CurrencyStringJson;
            using (Stream stream = WebResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                CurrencyStringJson = reader.ReadToEnd();
            }

            List<CurrencyModel> currencyModels = JsonConvert.DeserializeObject<List<CurrencyModel>>(CurrencyStringJson);

            ViewBag.curr = currencyModels;
            
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}