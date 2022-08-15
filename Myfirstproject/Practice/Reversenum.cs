using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Practice
{
    class Reversenum
    {
        static void Main(string[] args)
        {
            int num, r, rev = 0;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                r = num % 10;
                rev = rev * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(rev);
            
        }
    }
}
