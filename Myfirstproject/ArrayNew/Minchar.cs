using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Minchar
    {
        public static char Findminmum(char[]a)
        {
            char min =a[0];
            for(int i=0;i<a.Length;i++)
            {

                if (min>a[i])
                {
                    min = a[i];
                }
            }
            return min;

            
        }
        static void Main(string[] args)
        {
            char[] b = { 'v', 'u', 'Z', 'D', 'k' };
            char minimum = Minchar.Findminmum(b);
            Console.WriteLine("Minmium char="+minimum);
        }
    }
}
