using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmentno1
{
    class Numberdiv11
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            if (num%5==0 && num%11==0)
            {
                Console.WriteLine("number is Divisible");
            }
            else
            {
                Console.WriteLine("number is not Divisible");
            }
        }
    }
}
