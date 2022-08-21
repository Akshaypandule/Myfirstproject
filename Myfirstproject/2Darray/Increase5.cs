using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Increase5
    {
        public static void increase(int[,]arr)
        {
            int inc = 0;
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    inc += 5;
                    arr[i, j] = inc;
                    
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Increase5.increase(arr);
        }
    }
}
