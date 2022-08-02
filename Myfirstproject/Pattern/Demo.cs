using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class Demo
    {
        static void Main(string[] args)
        {
            int i, j, k, m, n;
            for (i = 1; i <= 4; i++)
            {
                for (j = 4; j >= i; j--)
                    Console.Write("  ");
                for (k = 1; k <= i; k++)
                    Console.Write(k + " ");
                n = k - 1;
                for (m = 1; m < i; m++)
                    Console.Write(--n + " ");
                Console.WriteLine();
            }
        }
    }
}








