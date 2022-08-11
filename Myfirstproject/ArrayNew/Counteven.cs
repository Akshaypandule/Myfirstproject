using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Counteven
    {
        public int Count_even(int[]a)
        {
            int i;
            int even = 0;
            for(i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                { 
                    even++;
                }
            }
            return even;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Counteven b = new Counteven();
            int even = b.Count_even(a);
            Console.WriteLine("Count even number = "+even);
        }
    }
}
