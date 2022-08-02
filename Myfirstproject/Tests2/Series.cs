using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class Series
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i<=num)
            {
               int b = i *i-1;
                Console.WriteLine(b+" ");
                i++;
            }
        }
    }
}
