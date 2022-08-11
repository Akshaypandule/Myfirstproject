using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Countoddelemnt
    {
        public int Oddnum(int[]a)
        {
             int odd = 0;
            int i;
            for(i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    odd++;
                }
            }
            return odd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Countoddelemnt b = new Countoddelemnt();
            int odd =b.Oddnum(a);
            Console.WriteLine("Enter the odd count=" +odd);

        }
    }
}
