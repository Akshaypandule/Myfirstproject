using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class C2
    {
        public float Selling(float costprice, float profit, float numitem)
        {
            float sellingprice = ((costprice) * (100 + profit) / 100);
            return sellingprice;
        }
        static void Main(string[] args)
        {
            float costprice = float.Parse(Console.ReadLine());
            float profit = float.Parse(Console.ReadLine());
            float numitem = float.Parse(Console.ReadLine());
            C2 C = new C2();
            float result = C.Selling(costprice,profit,numitem);
            Console.WriteLine(result);
        }



    }    }
