using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    public class CurrencyConverter
    {
        public float Convert(string From, string To)
        {
            HttpClient hc = new HttpClient();
            var ret = hc.GetAsync("https://free.currconv.com/api/v7/convert?q=USD_TWD&compact=ultra&apiKey=54bbaef1017ad8e12f43").Result;
            var JSON = ret.Content.ReadAsStringAsync().Result;

            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(JSON);
            return data.USD_TWD;
        }

    }
}
