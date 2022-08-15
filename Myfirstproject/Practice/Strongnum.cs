using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Practice
{
    class Strongnum
    {
        static void Main(string[] args)
        {
            int num, f, i, r, s = 0;
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                r= num / 10;
                f = 1;
                i = 1;
                while(i<=r)
                {
                    f = f * i;
                    i++;
                }
                s = s + f;
                num = num / 10;
            }
            if(num==s)
            {
                Console.WriteLine("Number is Strong");
            }
            else
            {
                Console.WriteLine("Number is not strong");
            }

        }
    }
}
