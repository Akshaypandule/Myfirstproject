using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Reversearraydemo
    {
        public static int[] Reverse(int[]a)
        {
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ",arr));
            int [] r= Reversearraydemo.Reverse(arr);
            Console.WriteLine("......................");
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
