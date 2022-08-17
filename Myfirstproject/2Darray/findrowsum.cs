using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class findrowsum
    {
        public static void Sumofrow(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.Write("sum=" +sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 3, 2, 1 }, { 6, 5, 8 }, { 2, 4, 7 } };
            findrowsum.Sumofrow(arr);
        }
    }
}
