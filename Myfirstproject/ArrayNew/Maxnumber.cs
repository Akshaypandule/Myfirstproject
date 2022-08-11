using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Maxnumber
    {
        public static int Findmax(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];

                }
            }
            return max;
        }
        public static int Findmin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min++;
        }
        static void Main(string[] args)
        {
            int[] b = { 21, 15, 98, 1, 3 };
            int value = Maxnumber.Findmax(b);
            int min = Maxnumber.Findmin(b);
            Console.WriteLine("maxmum number=" + value);
            Console.WriteLine("Minmum num=" + min);
        }
    }
}
