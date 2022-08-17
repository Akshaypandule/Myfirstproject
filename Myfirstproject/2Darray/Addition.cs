using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Addition
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] b = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] c = new int[3, 3];

            int sum = 0;
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    sum = sum + c[i, j];

                }

            }
            Console.WriteLine("sum" + sum);
            Console.ReadLine();
        }
    }
}
