using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Maxandmincolumn
    {
        public static void colmax(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[0, i];
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (max < a[j,i])
                    {
                        max = a[j, i];
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("colmax="+max);
                Console.WriteLine();
            }
        }
        public static void colmin(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int min = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min >a[j, i])
                    {
                        min = a[j, i];
                    }
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("colmin=" + min);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Maxandmincolumn.colmax(arr);
            Maxandmincolumn.colmin(arr);
            

            
            
        }
    }
}
