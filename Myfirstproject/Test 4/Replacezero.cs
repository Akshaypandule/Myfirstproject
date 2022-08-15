using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test_4
{//WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
    class Replacezero
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] a1 = new int[a.Length];
            for (int i = 0; i < a1.Length; i++) 
            {
               
                if (a[i] == 0)
                {
                    a1[i] = 1;

                }
                else
                {
                    a1[i] = a[i];
                }
            }
            Console.WriteLine(string.Join(" ",a1));
            Console.ReadLine();
        }
    }
}
