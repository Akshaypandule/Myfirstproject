using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Ternaryoperation
{
    class Ternary
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            string str = num > 0 ? "number is Positive" : "number is negative";
            Console.WriteLine(str);
        }
    }
}
