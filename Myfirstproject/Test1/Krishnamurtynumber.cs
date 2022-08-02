using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class Krishnamurtynumber
    {
        static void Main(string[] args)
        {
            int num, t, v, sum = 0, b = 1, num2;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            t = num;
            num2 = num;
            while(num>0)
            {
                v = num % 10;
                for(int i=1;i<=v;i++)
                {
                    b = b * i;
                }
                sum = sum + b;
                b = 1;
                num = num / 10;
            }
            if (num2==sum)
            {
                Console.WriteLine("Krishnamurthy number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy number");
            }
        }
    }
}
