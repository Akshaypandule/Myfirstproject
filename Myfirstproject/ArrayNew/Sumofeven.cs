using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Sumofeven
    {
        public int Evensum (int[]a)
        {
            int sum = 0;
            int i;
            for(i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the arrey element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Sumofeven b = new Sumofeven();
            int sum = b.Evensum(arr);
            Console.WriteLine("Sum of even==" +sum);

        }
    }
}
