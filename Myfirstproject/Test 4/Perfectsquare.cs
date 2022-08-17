using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test_4
{
    class Perfectsquare
    {
        static void Main(string[] args)
        {
            int i;
            int count=0;
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[]a=new int [size];
            Console.WriteLine("Enter the array element");
            for( i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<a.Length;i++)
            {
                int seq = a[i] * a[i];
                for (int j=0;j<a.Length;j++)
                {

                    if (a[j] == seq)
                    {
                       count++;  
                    }
                }
                
            }
            Console.WriteLine(" " + count); 



        }
    }
    class Square
    {
        public void Display(int[]a)
        {
            int d = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>d)
                {
                    d = a[i];
                }
            }
            for (int i=1;i<a.Length;i++)
            {
                int seq = a[i];
                for(int j=1;j>0;j++)
                {
                    if(j*j>d)
                    {
                        break;
                    }
                    if(j*j==seq)
                    {
                        Console.WriteLine(" "+a[i]);
                        break;
                    }
                }
            }
        }
    }
    class Ans
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Square b = new Square();
            b.Display(ar);
                
        }
    }
}
