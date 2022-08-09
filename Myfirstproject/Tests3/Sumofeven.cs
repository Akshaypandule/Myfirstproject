using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class sumofeven
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int sum = 0;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            for(i=2;i<=num;i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum of even num="  +sum);
        }
    }
}
