using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops.Whileloop
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int n, nu, power, num=0;
            Console.WriteLine("enter the num");
            n = int.Parse(Console.ReadLine());

            nu = n;
            while(nu !=0)
            {
                power = nu % 10;
                num = num + power * power * power;
                nu = nu / 10;
            }
            if (num == n)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
        
    }
}
