using IsTradingTime.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTradingTime.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StockLibrary.IsTrading(Convert.ToDateTime("2022/12/23 9:30:01")));
            Console.ReadLine();
        }
    }
}
