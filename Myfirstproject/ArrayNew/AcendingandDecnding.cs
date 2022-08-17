using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class AcendingandDecnding
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the elelment");
            for( i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for(i=0;i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length/2;j++)
                {
                    if(a[i]>a[j])
                    {
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                   
                }
                for (int j = a.Length / 2; j < a.Length - 1; j++)
                {
                    if (a[i] < a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;

                    }


                }
            }
            for(i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
