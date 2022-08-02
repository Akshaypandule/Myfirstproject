using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Condition
{
    class conditiondemo3
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("enter the day number");
            day = int.Parse(Console.ReadLine());
            if(day==1)
            {
                Console.WriteLine("Monday");
            }
            else if(day==2)
            {
                Console.WriteLine("Tuseday");
            }
            else if(day==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if(day==4)
            {
                Console.WriteLine("Thursday");
            }
            else if(day==5)
            {
                Console.WriteLine("Friday");
            }
            else if(day==6)
            {
                Console.WriteLine("Saturday");
            }
            else if(day==7)
            {
                Console.WriteLine("sunday");
            }
        }
    }
}
