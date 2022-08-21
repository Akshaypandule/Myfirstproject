using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Pluspattern
    {
        public static void Plus(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if(i==2||j==2)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
           
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Console.WriteLine("Enter the array element");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Pluspattern.Plus(a);
        }
    }
}
