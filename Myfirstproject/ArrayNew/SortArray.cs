using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class SortArray
    {
        public static int[] Mysort(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" " ,arr));
            int[] b = SortArray.Mysort(arr);
            Console.WriteLine("...................");
            Console.WriteLine(string.Join(" ",b));

        }

    }
}
