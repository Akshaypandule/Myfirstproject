using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class Pattern            //
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                for (int j = i; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }


        }

    }
    class pattern2
    {

        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)

                    Console.Write(" ");
                for (int k = 5; k >= i ; k--)
                {
                    if (k% 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }

        }
    } 
    class Singlelooppattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=1;i<=num;)
            {
                if (count<i)
                {
                    Console.Write(i);
                    count++;
                }
                else
                {
                    Console.WriteLine();
                    count = 0;
                    i++;
                }
            }
        }
    }
}
