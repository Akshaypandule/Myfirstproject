using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Pattern_seq
    {
        public static void Outerelemnt(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Pattern_seq.Outerelemnt(arr);

        }
    }       
}       
        
