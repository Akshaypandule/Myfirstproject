using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmentno1
{
    class year
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("ENTER THE YEAR");
            y = int.Parse(Console.ReadLine());
            if ((y%4==0 && y%100!=0)|| y%400==0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        }
    }
}
