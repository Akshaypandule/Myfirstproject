using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Reversnum
    {
        static void Main(string[] args)
        {
            int[] a = { 20, 30, 60, 12, 55 };
            for(int i=a.Length-1;i>=0 ;i--)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
