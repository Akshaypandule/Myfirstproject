using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Practice
{
    class Table
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int t = 0;
            Console.WriteLine("Enter the number");
             n= int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                t = n * i;
                Console.WriteLine(t);
            }
        }
    }
}
