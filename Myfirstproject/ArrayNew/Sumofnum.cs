using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{   // Sum of Array element 
    class Sumofnum
    {
        public int Sumofele(int[] a)
        {
            int sum = 0;
            {
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
            Sumofnum b = new Sumofnum();
            int sum = b.Sumofele(a);
            Console.WriteLine("Sum of array element= "  +sum);
            
        }
    }
}
