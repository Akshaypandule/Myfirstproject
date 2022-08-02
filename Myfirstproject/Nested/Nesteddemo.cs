using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Nested
{
    class Nesteddemo
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the age of Person");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter the Weight of person");
            int Weight = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                if (Weight >= 50)
                {
                    Console.WriteLine("Person is eligible for blood donation");
                }
                else
                {
                    Console.WriteLine("Person is not eligible for blood donation");
                }
            }
            else
            {
                Console.WriteLine("Person is not eligible for blood donation");
            }




        }

    }

}
    

