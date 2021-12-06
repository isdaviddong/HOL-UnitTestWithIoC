using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class FinancyTests
    {
        [TestMethod()]
        public void SplitMoneyTest()
        {
            //注入測試用類別實作
            Financy f = new Financy(new FakeCurrencyConverter());
            var CostByPeople = f.SplitMoney(100, 5);
            Assert.IsTrue(CostByPeople.ToString().StartsWith("553.444"));
        }


    }
}