using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class harshadnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num");
            int num = int.Parse(Console.ReadLine());
            int num2;num2 = num;
            int rem = 0;
            int sum = 0;
            while(num >0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if (num2 % sum == 0)
            {
                Console.WriteLine("harshed number");
            }
            else
            {
                Console.WriteLine(" not harshed number");
            }
        }
    }
}
