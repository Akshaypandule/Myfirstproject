using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Columsum
    {
        public static void Sumofcolumn(int[,]a)
        {
            
            for (int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.WriteLine(a[j,i]+" ");
                }
                Console.Write("sum=" +sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 5, 6 }, { 7, 8, 9 },{ 45, 20, 19 } };
            Columsum.Sumofcolumn(arr);
        }
    }
}
