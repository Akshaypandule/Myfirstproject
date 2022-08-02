using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Nested
{
    class Oddevennested
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num;
            num = int.Parse(Console.ReadLine());
            
            if (num % 2 == 0 )
            {
                Console.WriteLine("hii even");
            }
            else if ((num >= 2 && num <= 6) && num% 2 != 0)
            {
                Console.WriteLine("hello odd");
            }
            else if ((num <= 10 && num >= 5) && num % 2 == 0)
            {
                Console.WriteLine("only even");

            }
            else if (num % 2!= 0 )
            {
                Console.WriteLine("Hello odd");
            }
           
          
        }

    }
}

    