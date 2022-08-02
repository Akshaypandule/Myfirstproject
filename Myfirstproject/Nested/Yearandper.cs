using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Nested
{
    class Yearandper
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Passout year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percetage");
            int per = int.Parse(Console.ReadLine());
            if (year == 2022)
            {
                if (per > 60)
                {
                    Console.WriteLine("Student is eligible for interview");
                }
                else
                {
                    Console.WriteLine("Student is Not eligible for interview");
                }
            }
            else
            {
                Console.WriteLine("Student is not eligible for interview");
            }
        }

    }

}
    

