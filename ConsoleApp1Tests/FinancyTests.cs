using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class FinancyTests
    {
        [TestMethod()]
        public void SplitMoneyTest()
        {
            //使用NSubstitute建立Fake物件
            var FakeCurrencyConverter = NSubstitute.Substitute.For<ICurrencyConverter>();
            //設定預計回傳值
            FakeCurrencyConverter.Convert("USD", "TWD").Returns(27.67222F);

            //注入測試用類別實作
            Financy f = new Financy(FakeCurrencyConverter);
            var CostByPeople = f.SplitMoney(100, 5);
            Assert.IsTrue(CostByPeople.ToString().StartsWith("553.444"));
        }


    }
}