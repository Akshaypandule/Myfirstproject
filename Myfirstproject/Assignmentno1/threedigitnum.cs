using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmentno1
{
    class threedigitnum
    {
        static void Main(string[] args)
        {
            int sum = 0,num2;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num>99 && num<1000)
            {
                Console.WriteLine("Three digit");
                num2 = num % 10;
                num = num;

               while(num>=10)
                {
                    num = num / 10;
                    sum = num + num2;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Not three digit");
            }
        }
    }
}
