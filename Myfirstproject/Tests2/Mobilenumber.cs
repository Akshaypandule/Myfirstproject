using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class Mobilenumber
    {
        static void Main(string[] args)
        {
            int num;
            int d;
            int count = 0;
            Console.WriteLine("Enter the mobile number");
             num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digit");
            d = int.Parse(Console.ReadLine());
            while (num >0)
            {
                if (num % 10 == d)
                    count++;
                num /= 10;


            }
            Console.WriteLine("digit frquency" + count);

            Console.WriteLine();
        }
    }
}
    
    
          
      
