using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Condition
{
    class Positivenegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if(num==0)
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
