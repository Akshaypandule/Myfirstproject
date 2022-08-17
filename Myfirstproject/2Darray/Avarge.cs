using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Avarge
    {
        public static void findavg(int[,] a)

        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                    sum = sum + a[i, j];
                    count++;
                }
               
                Console.WriteLine("Sum=" + sum +"count= " +count+ "Avg=" +sum/count);
            }
            Console.WriteLine();


        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Avarge.findavg(arr);
        }

    }
    class newAvg
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int sum = 0;
                int avg = 0;
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    sum = sum + a[i, j];
                    avg = sum / a.GetUpperBound(0);

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(a.GetUpperBound(0));
                Console.WriteLine("sum=" + sum + " " + "avg=" + avg);


            }
            Console.ReadLine();
        }
    }
}
