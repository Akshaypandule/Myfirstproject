using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class additionnumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                
            }
            Console.WriteLine("the sum is",+ sum);
        }
    }
}
