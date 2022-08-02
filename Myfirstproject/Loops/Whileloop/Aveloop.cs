using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops.Whileloop
{
    class Aveloop
    {
        static void Main(string[] args)
        {
            long num, i, sum = 0, count_num = 0;
            Console.WriteLine("Enter any number");
            num = long.Parse(Console.ReadLine());

            while(num>0)
            {
                i = num % 10;
                sum = sum + i;
                count_num++;
                num = sum / 10;   
            }
            Console.WriteLine($"number count is={count_num} and number count avg is ={(count_num + sum)}");
        }
    }
}
