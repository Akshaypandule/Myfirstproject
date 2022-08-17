using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Rowmaxmin
    {
        public static void Rowmax(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, 1];
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    if (max < a[j, i])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[j, i] + " ");
                }
                Console.Write("rowmax=" + max);
                Console.WriteLine();
            }
        }
        public static void Rowmin(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int min = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }
                    Console.Write(a[j, i] + " ");
                }
                Console.Write("rowmin=" + min);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Rowmaxmin.Rowmax(arr);
                Rowmaxmin.Rowmin(arr);
            }
        }
    }
}
