using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Condition
{
    class Conditiondemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=int.Parse (Console.ReadLine());
            if (num%5==0)
            {
                Console.WriteLine("divisible");
            }
            else
            { 
                Console.WriteLine("not divisible");

            }
        }
    }
}
