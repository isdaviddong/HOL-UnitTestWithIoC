using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    //擷取介面
    public interface ICurrencyConverter
    {
        float Convert(string From, string To);
    }

    //建立fake物件
    public class FakeCurrencyConverter : ICurrencyConverter
    {
        public float Convert(string From, string To)
        {
            return 27.67222F;
        }
    }

    public class CurrencyConverter : ICurrencyConverter 
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
