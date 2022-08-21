using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Sparsematrix
    {
        public static void display(int[,]a)
        {
            int b = 0;
            int k = 0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]!=0)
                    {
                        b++;
                    }
                    else
                    {
                        k++;
                    }    
                }
            }
            if (k>b)
            {
                Console.WriteLine("Sparsematrix");
            }
            else
            {
                Console.WriteLine("Not sparsmatrix");
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
            Sparsematrix.display(arr);
            
        }
    }
}
