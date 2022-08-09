using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Reversch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            char[] a = new char[size];
            Console.WriteLine("Enter the ch");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
                //Console.WriteLine(a[i]);

            }

            foreach (char c in a)
            {
                Console.WriteLine(a);
            }

        }
    }
    class Rechar
    {
        static void Main(string[] args)
        {
            char[] a = { 'a', 'b', 'c', 'd' };
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}
