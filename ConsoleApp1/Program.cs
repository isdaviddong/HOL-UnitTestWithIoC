using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console encoding to unicode
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("請輸入金額(USD):");
            var amount = int.Parse(Console.ReadLine()); //100
            Console.Write("請輸入人數:");
            var people = int.Parse(Console.ReadLine()); //5
            Console.ReadLine();
            Financy f = new Financy();
            var CostByPeople = f.SplitMoney(amount, people);
            Console.Write(CostByPeople);
        }
    }
}
