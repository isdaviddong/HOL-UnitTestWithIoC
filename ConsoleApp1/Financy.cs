using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Financy
    {
        public double USD2TWD(double amount)
        {
            var currencyConverter = new CurrencyConverter();
            double rate = currencyConverter.Convert("USD", "TWD");
            return amount * rate;
        }

        public double SplitMoney(double USDAmount, int People)
        {
            var currencyConverter = new CurrencyConverter();
            //使用到外部函式(抓取匯率)
            double rate = currencyConverter.Convert("USD", "TWD");
            //計算台幣總金額
            double Total = USDAmount * rate;
            //回傳一個人需要付多少錢(台幣)
            return Total / People;
        }
    }
}
