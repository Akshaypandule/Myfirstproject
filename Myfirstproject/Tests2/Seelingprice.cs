using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class Seelingprice
    {
        static void Selingpricece(int cost_price,int profit,int num_item)
        {
            double seelingprice = ((cost_price) * (100 + profit) / 100);
            Console.WriteLine(seelingprice);

        }
        static void Main(string[] args)
        {
            int cost_price = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());
            int num_item = int.Parse(Console.ReadLine());
            Seelingprice.Selingpricece(cost_price, profit, num_item);




        }
    }
}
