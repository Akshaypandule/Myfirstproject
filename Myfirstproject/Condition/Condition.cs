using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Condition
{
    class  condition
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine(num +"    is positive");
            }
            else
            {
                Console.WriteLine(num + "    in negative");
            }
        }
    }
}
