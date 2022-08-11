using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Minnum
    {
        public static int Findmin(int[]a)
        {
            int min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            return min++;
        }
        static void Main(string[] args)
        {
            int[] b = { 3, 10, 1, 98, 75, 45 };
            int value = Minnum.Findmin(b);
            Console.WriteLine("Minimum Number=" +value);

        }
    }
}
