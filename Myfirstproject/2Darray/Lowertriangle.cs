using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Lowertriangle
    {
        public static void display(int[,] a)
        {
            for (int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(j>=i)
                    {
                        Console.Write(" "+a[i,j]);
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
            Console.WriteLine("Enter the element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Lowertriangle.display(arr);
        }
    }   
}
        