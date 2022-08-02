using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Ternaryoperation
{
    class Ternaryfirst
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            string str = num % 2 == 0 ? "number is even" : "number is odd";
            Console.WriteLine(str);
        }
    }
}
