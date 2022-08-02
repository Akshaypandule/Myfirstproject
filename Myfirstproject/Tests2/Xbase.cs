using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class Xbase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the index");
            int index = int.Parse(Console.ReadLine());
            int power = 1;
            for(int i=1;i<=index;i++)
            {
                power = power * base1;

            }
            Console.WriteLine(" output is = " + power);
        }
    }
}
