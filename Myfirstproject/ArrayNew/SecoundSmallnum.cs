using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class SecoundSmallnum
    {
        public static void Secoundsmallnu(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    int temp;
                    if(a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        Console.WriteLine();
                    }
                    
                }
                Console.WriteLine(a[1]);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element");
            int i;
            for (i = 0; i < arr.Length; i++) 
            {
                
                    arr[i] = int.Parse(Console.ReadLine());
            }
            SecoundSmallnum.Secoundsmallnu(arr);
        }
    }
}
