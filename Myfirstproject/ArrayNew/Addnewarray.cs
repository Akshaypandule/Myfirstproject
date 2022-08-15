using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Addnewarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size odf array");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[k];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < k; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", a));

            int E1 = 0;
            int O1 = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                {

                    E1++;
                }
                else
                {
                    O1++;
                }
            }
            int[] even1 = new int[E1];
            int[] Odd = new int[O1];
            int x = 0;
            int y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even1[x++] = a[i];
                }
                else
                {
                    Odd[y++] = a[i];
                }
            }
            Console.WriteLine("even array element is");
            for (int i = 0; i < x; i++)
            {

                Console.WriteLine(even1[i]);

            }
            Console.WriteLine("odd array element is");
            for (int i = 0; i < y; i++)
            {

                Console.WriteLine(Odd[i]);

            }
        }
    }
}
